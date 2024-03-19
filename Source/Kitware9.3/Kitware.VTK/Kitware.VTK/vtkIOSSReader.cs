using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkIOSSReader
	/// </summary>
	/// <remarks>
	///  Reader for IOSS (Sierra IO System)
	///
	/// vtkIOSSReader is reader that uses the IOSS (Sierra IO System) library to
	/// read files. Currently, this reader support Exodus and CGNS file formats. IOSS
	/// imposes certain restrictions on these file formats and hence it may not be
	/// possible to open every Exodus or CGNS file using this reader. This is
	/// true especially for CGNS, more so than Exodus. In that case `vtkCGNSReader`
	/// may be more appropriate.
	///
	/// @section SpecifyingFiles Specifying Files
	///
	/// One can select a single file to read using `vtkIOSSReader::SetFileName`.
	/// With IOSS, however, it is not uncommon to have a collection of files named
	/// using standard patterns (described in Section @ref IossNamingConventions).
	/// To support this use-case, the reader automatically scans for additionally
	/// files internally. To disable this behaviour, call
	/// `vtkIOSSReader::ScanForRelatedFilesOff`.
	///
	/// Alternatively, the list of files to be read can be explicitly specified using
	/// `vtkIOSSReader::AddFileName`. Then too, if `ScanForRelatedFiles` is `true`,
	/// the reader will search for related files for each of the files specified.
	///
	/// Additionally, `FileRange` and `FileStride` may be used to limit to reading a
	/// subset of files.
	///
	/// @section SelectingBlocksSets Selecting blocks and sets to read
	///
	/// An IOSS file comprises of blocks and sets of various types. These are
	/// described by the enum `vtkIOSSReader::EntityType`.
	///
	/// `vtkIOSSReader::GetEntitySelection` returns a `vtkDataArraySelection`
	/// instance for each of the entity types. This `vtkDataArraySelection` can be
	/// used to query the names for available blocks or sets and also select which
	/// ones to read.
	///
	/// Typical usage is as follows:
	///
	/// @code{.cpp}
	///
	/// vtkNew&lt;vtkIOSSReader&gt; reader;
	/// reader-&gt;SetFileName(...);
	/// reader-&gt;UpdateInformation();
	/// reader-&gt;GetElementBlockSelection()-&gt;EnableArray("Block0");
	/// reader-&gt;GetEntitySelection(vtkIOSSReader::SIDESET)-&gt;DisableAllArrays();
	/// @endcode
	///
	/// By default, all blocks are enabled, while all sets are disabled.
	///
	/// In additional to selecting blocks and sets by name, if the file defines assemblies
	/// that organize these blocks and sets, then one can use selector expressions
	/// to enable blocks/sets as defined in the assemblies.
	///
	/// A block (or set) is treated as enabled if it is either explicitly enabled using the
	/// block selection or implicitly enabled due to a selector specified on over the assemblies.
	///
	/// Typical usage to select blocks by assembly alone is as follows:
	///
	/// @code{.cpp}
	/// vtkNew&lt;vtkIOSSReader&gt; reader;
	/// reader-&gt;SetFileName(...);
	/// reader-&gt;UpdateInformation();
	/// reader-&gt;GetElementBlockSelection()-&gt;DisableAllArrays();
	/// ...
	/// reader-&gt;AddSelector("//Low");
	/// reader-&gt;AddSelector("//High");
	/// @endcode
	///
	/// @section SelectingArrays Selecting arrays to read
	///
	/// Similar to the block and set selection, arrays (or fields as IOSS refers to
	/// them) to read from each of the blocks or sets can be specified using the
	/// `vtkDataArraySelection` instance returned using
	/// `vtkIOSSReader::GetFieldSelection` (or one of its convenience variants).
	///
	/// By default all arrays are enabled.
	///
	/// @section IossNamingConventions IOSS Naming Conventions
	///
	/// An IOSS complete dataset is referred to as a database. There can be multiple
	/// multiple timesteps in a single database. A single database may
	/// split among multiple files. When a database is split among multiple files,
	/// this is strictly spatial partitioning with each file storing part of the data
	/// for a specific partition. In this case, the files are named with suffix
	/// `.{NP}.{RANK}` where `{NP}` is the total number of partitions  and `{RANK}`
	/// is the partition number. For example, if database named `can.e` is split among four
	/// files representing 4 partitions, it will be named as follows:
	///
	/// @verbatim
	///  can.e.4.0
	///  can.e.4.1
	///  can.e.4.2
	///  can.e.4.3
	/// @endverbatim
	///
	/// In this example, the database name is `can.e` while the `.4.[0-4]` suffix
	/// provides the partition information.
	///
	/// Note, the database need not be split into multiple files. Thus, a writer may
	/// generate a single `can.e` file that has all the timesteps and partitions and
	/// still provide all information available when the database is split among
	/// multiple files.
	///
	/// Multiple databases (with each stored in a single file or spatially split among files)
	/// can form a temporal sequence. This done by using another file naming
	/// convention. If the database name is followed by `-s.{RS}`, where `{RS}` is
	/// some number sequence), then the databases are treated as a temporal sequence
	/// with `{RS}` (called restart numbers) representing the temporal sequence
	/// order.
	///
	/// The follow represents a temporal sequence:
	///
	/// @verbatim
	///  mysimoutput.e-s.000
	///  mysimoutput.e-s.001
	///  mysimoutput.e-s.002
	/// @endverbatim
	///
	/// You can use any number of digits for the restart number, but by convention
	/// the number used should be the same for all files. Also by convention, you can
	/// leave off the `-s.{RS}` suffix for the first file. The following
	/// sequence is internally the same as that above:
	///
	/// @verbatim
	///  mysimoutput.e-s
	///  mysimoutput.e-s.001
	///  mysimoutput.e-s.002
	/// @endverbatim
	///
	/// When a database in the temporal sequence is spatially split in multiple
	/// files, the corresponding filename is suffixed by the partition information.
	/// For example:
	///
	/// @verbatim
	///  mysimoutput.e-s.2.0
	///  mysimoutput.e-s.2.1
	///  mysimoutput.e-s.001.2.0
	///  mysimoutput.e-s.001.2.1
	///  mysimoutput.e-s.002.2.0
	///  mysimoutput.e-s.002.2.1
	/// @endverbatim
	///
	/// In this case, the filenames take the form `{DBNAME}-s.{RS}.{NP}.{RANK}`,
	/// where `{DBNAME}` is the database name, `{RS}` is the restart number,
	/// `{NP}` is the number of spatial partitions and `{RANK}` is the spatial partition number.
	///
	/// @section References References
	/// * [Sierra IO System](https://sandialabs.github.io/seacas-docs)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkIOSSWriter, vtkExodusIIReader, vtkCGNSReader
	/// </seealso>
	// Token: 0x02000189 RID: 393
	public class vtkIOSSReader : vtkReaderAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004B59 RID: 19289 RVA: 0x0006DB9B File Offset: 0x0006BD9B
		static vtkIOSSReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIOSSReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIOSSReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004B5A RID: 19290 RVA: 0x0006DBC3 File Offset: 0x0006BDC3
		public vtkIOSSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004B5B RID: 19291
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B5C RID: 19292 RVA: 0x0006DBD4 File Offset: 0x0006BDD4
		public new static vtkIOSSReader New()
		{
			vtkIOSSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIOSSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B5D RID: 19293 RVA: 0x0006DC28 File Offset: 0x0006BE28
		public vtkIOSSReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIOSSReader.vtkIOSSReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004B5E RID: 19294 RVA: 0x0006DC6C File Offset: 0x0006BE6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004B5F RID: 19295
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_AddFileName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// API to set the filenames.
		/// </summary>
		// Token: 0x06004B60 RID: 19296 RVA: 0x0006DC77 File Offset: 0x0006BE77
		public void AddFileName(string fname)
		{
			vtkIOSSReader.vtkIOSSReader_AddFileName_01(base.GetCppThis(), fname);
		}

		// Token: 0x06004B61 RID: 19297
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_AddProperty_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int value);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B62 RID: 19298 RVA: 0x0006DC87 File Offset: 0x0006BE87
		public void AddProperty(string name, int value)
		{
			vtkIOSSReader.vtkIOSSReader_AddProperty_02(base.GetCppThis(), name, value);
		}

		// Token: 0x06004B63 RID: 19299
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_AddProperty_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double value);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B64 RID: 19300 RVA: 0x0006DC98 File Offset: 0x0006BE98
		public void AddProperty(string name, double value)
		{
			vtkIOSSReader.vtkIOSSReader_AddProperty_03(base.GetCppThis(), name, value);
		}

		// Token: 0x06004B65 RID: 19301
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_AddProperty_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr value);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B66 RID: 19302 RVA: 0x0006DCA9 File Offset: 0x0006BEA9
		public void AddProperty(string name, IntPtr value)
		{
			vtkIOSSReader.vtkIOSSReader_AddProperty_04(base.GetCppThis(), name, value);
		}

		// Token: 0x06004B67 RID: 19303
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_AddProperty_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B68 RID: 19304 RVA: 0x0006DCBA File Offset: 0x0006BEBA
		public void AddProperty(string name, string value)
		{
			vtkIOSSReader.vtkIOSSReader_AddProperty_05(base.GetCppThis(), name, value);
		}

		// Token: 0x06004B69 RID: 19305
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_AddSelector_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// API to specify selectors that indicate which branches on the assembly are
		/// chosen.
		/// </summary>
		// Token: 0x06004B6A RID: 19306 RVA: 0x0006DCCC File Offset: 0x0006BECC
		public bool AddSelector(string selector)
		{
			return vtkIOSSReader.vtkIOSSReader_AddSelector_06(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004B6B RID: 19307
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ApplyDisplacementsOff_07(HandleRef pThis);

		/// <summary>
		/// When set to true (default), if an array named 'displacement' is present in
		/// the node field arrays, it will be used to transform the point coordinates.
		/// </summary>
		// Token: 0x06004B6C RID: 19308 RVA: 0x0006DCF3 File Offset: 0x0006BEF3
		public virtual void ApplyDisplacementsOff()
		{
			vtkIOSSReader.vtkIOSSReader_ApplyDisplacementsOff_07(base.GetCppThis());
		}

		// Token: 0x06004B6D RID: 19309
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ApplyDisplacementsOn_08(HandleRef pThis);

		/// <summary>
		/// When set to true (default), if an array named 'displacement' is present in
		/// the node field arrays, it will be used to transform the point coordinates.
		/// </summary>
		// Token: 0x06004B6E RID: 19310 RVA: 0x0006DD02 File Offset: 0x0006BF02
		public virtual void ApplyDisplacementsOn()
		{
			vtkIOSSReader.vtkIOSSReader_ApplyDisplacementsOn_08(base.GetCppThis());
		}

		// Token: 0x06004B6F RID: 19311
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ClearFileNames_09(HandleRef pThis);

		/// <summary>
		/// API to set the filenames.
		/// </summary>
		// Token: 0x06004B70 RID: 19312 RVA: 0x0006DD11 File Offset: 0x0006BF11
		public void ClearFileNames()
		{
			vtkIOSSReader.vtkIOSSReader_ClearFileNames_09(base.GetCppThis());
		}

		// Token: 0x06004B71 RID: 19313
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ClearProperties_10(HandleRef pThis);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B72 RID: 19314 RVA: 0x0006DD20 File Offset: 0x0006BF20
		public void ClearProperties()
		{
			vtkIOSSReader.vtkIOSSReader_ClearProperties_10(base.GetCppThis());
		}

		// Token: 0x06004B73 RID: 19315
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ClearSelectors_11(HandleRef pThis);

		/// <summary>
		/// API to specify selectors that indicate which branches on the assembly are
		/// chosen.
		/// </summary>
		// Token: 0x06004B74 RID: 19316 RVA: 0x0006DD2F File Offset: 0x0006BF2F
		public void ClearSelectors()
		{
			vtkIOSSReader.vtkIOSSReader_ClearSelectors_11(base.GetCppThis());
		}

		// Token: 0x06004B75 RID: 19317
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_DoTestFilePatternMatching_12();

		/// <summary>
		/// Runs a bunch of tests for file pattern matching.
		/// </summary>
		// Token: 0x06004B76 RID: 19318 RVA: 0x0006DD40 File Offset: 0x0006BF40
		public static bool DoTestFilePatternMatching()
		{
			return vtkIOSSReader.vtkIOSSReader_DoTestFilePatternMatching_12() != 0;
		}

		// Token: 0x06004B77 RID: 19319
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_ENTITY_ID_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Overridden to release handles at the end of each pass.
		/// </summary>
		// Token: 0x06004B78 RID: 19320 RVA: 0x0006DD60 File Offset: 0x0006BF60
		public static vtkInformationIntegerKey ENTITY_ID()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_ENTITY_ID_13(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06004B79 RID: 19321
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ElementAndSideIdsOff_14(HandleRef pThis);

		/// <summary>
		/// When this flag is on and MergeExodusEntityBlocks is off,
		/// side sets of exodus data will be annotated with field-data
		/// arrays holding the element-id and side-id for each output cell.
		///
		/// This flag is true/on by default.
		///
		/// Note: This flag is ignored for non-exodus data and when
		/// MergeExodusEntityBlocks is enabled.
		/// </summary>
		// Token: 0x06004B7A RID: 19322 RVA: 0x0006DDC9 File Offset: 0x0006BFC9
		public virtual void ElementAndSideIdsOff()
		{
			vtkIOSSReader.vtkIOSSReader_ElementAndSideIdsOff_14(base.GetCppThis());
		}

		// Token: 0x06004B7B RID: 19323
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ElementAndSideIdsOn_15(HandleRef pThis);

		/// <summary>
		/// When this flag is on and MergeExodusEntityBlocks is off,
		/// side sets of exodus data will be annotated with field-data
		/// arrays holding the element-id and side-id for each output cell.
		///
		/// This flag is true/on by default.
		///
		/// Note: This flag is ignored for non-exodus data and when
		/// MergeExodusEntityBlocks is enabled.
		/// </summary>
		// Token: 0x06004B7C RID: 19324 RVA: 0x0006DDD8 File Offset: 0x0006BFD8
		public virtual void ElementAndSideIdsOn()
		{
			vtkIOSSReader.vtkIOSSReader_ElementAndSideIdsOn_15(base.GetCppThis());
		}

		// Token: 0x06004B7D RID: 19325
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_GenerateFileIdOff_16(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader will add a cell-data array for cells named
		/// 'file_id' which identifies the file number when reading spatially
		/// partitioned files.
		///
		/// Default is false.
		/// </summary>
		// Token: 0x06004B7E RID: 19326 RVA: 0x0006DDE7 File Offset: 0x0006BFE7
		public virtual void GenerateFileIdOff()
		{
			vtkIOSSReader.vtkIOSSReader_GenerateFileIdOff_16(base.GetCppThis());
		}

		// Token: 0x06004B7F RID: 19327
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_GenerateFileIdOn_17(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader will add a cell-data array for cells named
		/// 'file_id' which identifies the file number when reading spatially
		/// partitioned files.
		///
		/// Default is false.
		/// </summary>
		// Token: 0x06004B80 RID: 19328 RVA: 0x0006DDF6 File Offset: 0x0006BFF6
		public virtual void GenerateFileIdOn()
		{
			vtkIOSSReader.vtkIOSSReader_GenerateFileIdOn_17(base.GetCppThis());
		}

		// Token: 0x06004B81 RID: 19329
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetApplyDisplacements_18(HandleRef pThis);

		/// <summary>
		/// When set to true (default), if an array named 'displacement' is present in
		/// the node field arrays, it will be used to transform the point coordinates.
		/// </summary>
		// Token: 0x06004B82 RID: 19330 RVA: 0x0006DE08 File Offset: 0x0006C008
		public virtual bool GetApplyDisplacements()
		{
			return vtkIOSSReader.vtkIOSSReader_GetApplyDisplacements_18(base.GetCppThis()) != 0;
		}

		// Token: 0x06004B83 RID: 19331
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetAssembly_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Assemblies provide yet another way of selection blocks/sets to load, if
		/// available in the dataset. If a block (or set) is enabled either in the
		/// block (or set) selection or using assembly selector then it is treated as
		/// enabled and will be read.
		///
		/// This method returns the vtkDataAssembly. Since IOSS can have multiple
		/// assemblies, all are nested under the root "Assemblies" node.
		///
		/// If the file has no assemblies, this will return nullptr.
		/// </summary>
		// Token: 0x06004B84 RID: 19332 RVA: 0x0006DE30 File Offset: 0x0006C030
		public vtkDataAssembly GetAssembly()
		{
			vtkDataAssembly vtkDataAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetAssembly_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataAssembly = (vtkDataAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataAssembly.Register(null);
				}
			}
			return vtkDataAssembly;
		}

		// Token: 0x06004B85 RID: 19333
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_GetAssemblyTag_20(HandleRef pThis);

		/// <summary>
		/// Whenever the assembly is changed, this tag gets changed. Note, users should
		/// not assume that this is monotonically increasing but instead simply rely on
		/// its value to determine if the assembly may have changed since last time.
		///
		/// It is set to 0 whenever there's no valid assembly available.
		/// </summary>
		// Token: 0x06004B86 RID: 19334 RVA: 0x0006DEA0 File Offset: 0x0006C0A0
		public virtual int GetAssemblyTag()
		{
			return vtkIOSSReader.vtkIOSSReader_GetAssemblyTag_20(base.GetCppThis());
		}

		// Token: 0x06004B87 RID: 19335
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetController_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use when working in parallel. Initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		///
		/// The controller is used to using `ReadMetaData` stage to distribute the work
		/// of gathering meta-data from multiple files, if any, across ranks and then
		/// exchanging that information between all ranks.
		///
		/// The actual reading of data is controlled by piece requests sent by the
		/// pipeline e.g. using `vtkAlgorithm::UpdatePiece`.
		/// </summary>
		// Token: 0x06004B88 RID: 19336 RVA: 0x0006DEC0 File Offset: 0x0006C0C0
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetController_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B89 RID: 19337
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetDataAssemblyNodeNameForEntityType_22(int type);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B8A RID: 19338 RVA: 0x0006DF30 File Offset: 0x0006C130
		public static string GetDataAssemblyNodeNameForEntityType(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSReader.vtkIOSSReader_GetDataAssemblyNodeNameForEntityType_22(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004B8B RID: 19339
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetDatabaseTypeOverride_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the IOSS database name to use for reading the file. If not
		/// specified (default), the reader will determine based on the file extension.
		/// </summary>
		// Token: 0x06004B8C RID: 19340 RVA: 0x0006DF68 File Offset: 0x0006C168
		public virtual string GetDatabaseTypeOverride()
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSReader.vtkIOSSReader_GetDatabaseTypeOverride_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004B8D RID: 19341
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIOSSReader_GetDisplacementMagnitude_24(HandleRef pThis);

		/// <summary>
		/// When displacements are being applied, they are scaled by this amount. Set to 1 (default) for no
		/// scaling.
		/// </summary>
		// Token: 0x06004B8E RID: 19342 RVA: 0x0006DFA4 File Offset: 0x0006C1A4
		public double GetDisplacementMagnitude()
		{
			return vtkIOSSReader.vtkIOSSReader_GetDisplacementMagnitude_24(base.GetCppThis());
		}

		// Token: 0x06004B8F RID: 19343
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEdgeBlockFieldSelection_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B90 RID: 19344 RVA: 0x0006DFC4 File Offset: 0x0006C1C4
		public vtkDataArraySelection GetEdgeBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEdgeBlockFieldSelection_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B91 RID: 19345
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEdgeBlockIdMapAsString_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004B92 RID: 19346 RVA: 0x0006E034 File Offset: 0x0006C234
		public vtkStringArray GetEdgeBlockIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEdgeBlockIdMapAsString_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B93 RID: 19347
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEdgeBlockSelection_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B94 RID: 19348 RVA: 0x0006E0A4 File Offset: 0x0006C2A4
		public vtkDataArraySelection GetEdgeBlockSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEdgeBlockSelection_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B95 RID: 19349
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEdgeSetFieldSelection_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B96 RID: 19350 RVA: 0x0006E114 File Offset: 0x0006C314
		public vtkDataArraySelection GetEdgeSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEdgeSetFieldSelection_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B97 RID: 19351
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEdgeSetIdMapAsString_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004B98 RID: 19352 RVA: 0x0006E184 File Offset: 0x0006C384
		public vtkStringArray GetEdgeSetIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEdgeSetIdMapAsString_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B99 RID: 19353
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEdgeSetSelection_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B9A RID: 19354 RVA: 0x0006E1F4 File Offset: 0x0006C3F4
		public vtkDataArraySelection GetEdgeSetSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEdgeSetSelection_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B9B RID: 19355
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetElementAndSideIds_31(HandleRef pThis);

		/// <summary>
		/// When this flag is on and MergeExodusEntityBlocks is off,
		/// side sets of exodus data will be annotated with field-data
		/// arrays holding the element-id and side-id for each output cell.
		///
		/// This flag is true/on by default.
		///
		/// Note: This flag is ignored for non-exodus data and when
		/// MergeExodusEntityBlocks is enabled.
		/// </summary>
		// Token: 0x06004B9C RID: 19356 RVA: 0x0006E264 File Offset: 0x0006C464
		public virtual bool GetElementAndSideIds()
		{
			return vtkIOSSReader.vtkIOSSReader_GetElementAndSideIds_31(base.GetCppThis()) != 0;
		}

		// Token: 0x06004B9D RID: 19357
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetElementBlockFieldSelection_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004B9E RID: 19358 RVA: 0x0006E28C File Offset: 0x0006C48C
		public vtkDataArraySelection GetElementBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetElementBlockFieldSelection_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004B9F RID: 19359
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetElementBlockIdMapAsString_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BA0 RID: 19360 RVA: 0x0006E2FC File Offset: 0x0006C4FC
		public vtkStringArray GetElementBlockIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetElementBlockIdMapAsString_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BA1 RID: 19361
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetElementBlockSelection_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BA2 RID: 19362 RVA: 0x0006E36C File Offset: 0x0006C56C
		public vtkDataArraySelection GetElementBlockSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetElementBlockSelection_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BA3 RID: 19363
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetElementSetFieldSelection_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BA4 RID: 19364 RVA: 0x0006E3DC File Offset: 0x0006C5DC
		public vtkDataArraySelection GetElementSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetElementSetFieldSelection_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BA5 RID: 19365
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetElementSetIdMapAsString_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BA6 RID: 19366 RVA: 0x0006E44C File Offset: 0x0006C64C
		public vtkStringArray GetElementSetIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetElementSetIdMapAsString_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BA7 RID: 19367
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetElementSetSelection_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BA8 RID: 19368 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		public vtkDataArraySelection GetElementSetSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetElementSetSelection_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BA9 RID: 19369
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEntityIdMapAsString_38(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BAA RID: 19370 RVA: 0x0006E52C File Offset: 0x0006C72C
		public vtkStringArray GetEntityIdMapAsString(int type)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEntityIdMapAsString_38(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BAB RID: 19371
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetEntitySelection_39(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BAC RID: 19372 RVA: 0x0006E59C File Offset: 0x0006C79C
		public vtkDataArraySelection GetEntitySelection(int type)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetEntitySelection_39(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BAD RID: 19373
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetEntityTypeIsBlock_40(int type);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BAE RID: 19374 RVA: 0x0006E60C File Offset: 0x0006C80C
		public static bool GetEntityTypeIsBlock(int type)
		{
			return vtkIOSSReader.vtkIOSSReader_GetEntityTypeIsBlock_40(type) != 0;
		}

		// Token: 0x06004BAF RID: 19375
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetEntityTypeIsSet_41(int type);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BB0 RID: 19376 RVA: 0x0006E630 File Offset: 0x0006C830
		public static bool GetEntityTypeIsSet(int type)
		{
			return vtkIOSSReader.vtkIOSSReader_GetEntityTypeIsSet_41(type) != 0;
		}

		// Token: 0x06004BB1 RID: 19377
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFaceBlockFieldSelection_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BB2 RID: 19378 RVA: 0x0006E654 File Offset: 0x0006C854
		public vtkDataArraySelection GetFaceBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFaceBlockFieldSelection_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BB3 RID: 19379
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFaceBlockIdMapAsString_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BB4 RID: 19380 RVA: 0x0006E6C4 File Offset: 0x0006C8C4
		public vtkStringArray GetFaceBlockIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFaceBlockIdMapAsString_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BB5 RID: 19381
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFaceBlockSelection_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BB6 RID: 19382 RVA: 0x0006E734 File Offset: 0x0006C934
		public vtkDataArraySelection GetFaceBlockSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFaceBlockSelection_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BB7 RID: 19383
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFaceSetFieldSelection_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BB8 RID: 19384 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		public vtkDataArraySelection GetFaceSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFaceSetFieldSelection_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BB9 RID: 19385
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFaceSetIdMapAsString_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BBA RID: 19386 RVA: 0x0006E814 File Offset: 0x0006CA14
		public vtkStringArray GetFaceSetIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFaceSetIdMapAsString_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BBB RID: 19387
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFaceSetSelection_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BBC RID: 19388 RVA: 0x0006E884 File Offset: 0x0006CA84
		public vtkDataArraySelection GetFaceSetSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFaceSetSelection_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BBD RID: 19389
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFieldSelection_48(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BBE RID: 19390 RVA: 0x0006E8F4 File Offset: 0x0006CAF4
		public vtkDataArraySelection GetFieldSelection(int type)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFieldSelection_48(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BBF RID: 19391
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkIOSSReader_GetFieldSuffixSeparator_49(HandleRef pThis);

		/// <summary>
		/// Set the character used to separate suffix from the field.
		/// </summary>
		// Token: 0x06004BC0 RID: 19392 RVA: 0x0006E964 File Offset: 0x0006CB64
		public string GetFieldSuffixSeparator()
		{
			return vtkIOSSReader.vtkIOSSReader_GetFieldSuffixSeparator_49(base.GetCppThis());
		}

		// Token: 0x06004BC1 RID: 19393
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFileName_50(HandleRef pThis, int index);

		/// <summary>
		/// API to set the filenames.
		/// </summary>
		// Token: 0x06004BC2 RID: 19394 RVA: 0x0006E984 File Offset: 0x0006CB84
		public string GetFileName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSReader.vtkIOSSReader_GetFileName_50(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004BC3 RID: 19395
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetFileRange_51(HandleRef pThis);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004BC4 RID: 19396 RVA: 0x0006E9C0 File Offset: 0x0006CBC0
		public virtual int[] GetFileRange()
		{
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetFileRange_51(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004BC5 RID: 19397
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_GetFileRange_52(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004BC6 RID: 19398 RVA: 0x0006EA08 File Offset: 0x0006CC08
		public virtual void GetFileRange(ref int _arg1, ref int _arg2)
		{
			vtkIOSSReader.vtkIOSSReader_GetFileRange_52(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06004BC7 RID: 19399
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_GetFileRange_53(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004BC8 RID: 19400 RVA: 0x0006EA19 File Offset: 0x0006CC19
		public virtual void GetFileRange(IntPtr _arg)
		{
			vtkIOSSReader.vtkIOSSReader_GetFileRange_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06004BC9 RID: 19401
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_GetFileStride_54(HandleRef pThis);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004BCA RID: 19402 RVA: 0x0006EA2C File Offset: 0x0006CC2C
		public virtual int GetFileStride()
		{
			return vtkIOSSReader.vtkIOSSReader_GetFileStride_54(base.GetCppThis());
		}

		// Token: 0x06004BCB RID: 19403
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_GetFileStrideMaxValue_55(HandleRef pThis);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004BCC RID: 19404 RVA: 0x0006EA4C File Offset: 0x0006CC4C
		public virtual int GetFileStrideMaxValue()
		{
			return vtkIOSSReader.vtkIOSSReader_GetFileStrideMaxValue_55(base.GetCppThis());
		}

		// Token: 0x06004BCD RID: 19405
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_GetFileStrideMinValue_56(HandleRef pThis);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004BCE RID: 19406 RVA: 0x0006EA6C File Offset: 0x0006CC6C
		public virtual int GetFileStrideMinValue()
		{
			return vtkIOSSReader.vtkIOSSReader_GetFileStrideMinValue_56(base.GetCppThis());
		}

		// Token: 0x06004BCF RID: 19407
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetGenerateFileId_57(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader will add a cell-data array for cells named
		/// 'file_id' which identifies the file number when reading spatially
		/// partitioned files.
		///
		/// Default is false.
		/// </summary>
		// Token: 0x06004BD0 RID: 19408 RVA: 0x0006EA8C File Offset: 0x0006CC8C
		public virtual bool GetGenerateFileId()
		{
			return vtkIOSSReader.vtkIOSSReader_GetGenerateFileId_57(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BD1 RID: 19409
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetGroupNumericVectorFieldComponents_58(HandleRef pThis);

		/// <summary>
		/// Set whether the reader should treat numeric suffixes for a vector field as vector components.
		/// By default, this property is off.
		/// Example: DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4
		/// If the property is true, those fields will be parsed as a 4-component vtkDataArray
		/// named DENSITY.
		/// When turned off, DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4 fields will be parsed as 4
		/// vtkDataArrays with 1 component each.
		/// </summary>
		// Token: 0x06004BD2 RID: 19410 RVA: 0x0006EAB4 File Offset: 0x0006CCB4
		public bool GetGroupNumericVectorFieldComponents()
		{
			return vtkIOSSReader.vtkIOSSReader_GetGroupNumericVectorFieldComponents_58(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BD3 RID: 19411
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkIOSSReader_GetMTime_59(HandleRef pThis);

		/// <summary>
		/// Overridden to take into account mtimes for vtkDataArraySelection instances.
		/// </summary>
		// Token: 0x06004BD4 RID: 19412 RVA: 0x0006EADC File Offset: 0x0006CCDC
		public override ulong GetMTime()
		{
			return vtkIOSSReader.vtkIOSSReader_GetMTime_59(base.GetCppThis());
		}

		// Token: 0x06004BD5 RID: 19413
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetMergeExodusEntityBlocks_60(HandleRef pThis);

		/// <summary>
		/// When this flag is on, blocks/sets of like exodus types will be merged.
		///
		/// Note: This flag is ignored for non-exodus data.
		/// </summary>
		// Token: 0x06004BD6 RID: 19414 RVA: 0x0006EAFC File Offset: 0x0006CCFC
		public virtual bool GetMergeExodusEntityBlocks()
		{
			return vtkIOSSReader.vtkIOSSReader_GetMergeExodusEntityBlocks_60(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BD7 RID: 19415
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetMergedEntityNameForEntityType_61(int type);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BD8 RID: 19416 RVA: 0x0006EB24 File Offset: 0x0006CD24
		public static string GetMergedEntityNameForEntityType(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSReader.vtkIOSSReader_GetMergedEntityNameForEntityType_61(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004BD9 RID: 19417
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetNodeBlockFieldSelection_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BDA RID: 19418 RVA: 0x0006EB5C File Offset: 0x0006CD5C
		public vtkDataArraySelection GetNodeBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetNodeBlockFieldSelection_62(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BDB RID: 19419
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetNodeBlockIdMapAsString_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BDC RID: 19420 RVA: 0x0006EBCC File Offset: 0x0006CDCC
		public vtkStringArray GetNodeBlockIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetNodeBlockIdMapAsString_63(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BDD RID: 19421
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetNodeBlockSelection_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BDE RID: 19422 RVA: 0x0006EC3C File Offset: 0x0006CE3C
		public vtkDataArraySelection GetNodeBlockSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetNodeBlockSelection_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BDF RID: 19423
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetNodeSetFieldSelection_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BE0 RID: 19424 RVA: 0x0006ECAC File Offset: 0x0006CEAC
		public vtkDataArraySelection GetNodeSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetNodeSetFieldSelection_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BE1 RID: 19425
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetNodeSetIdMapAsString_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BE2 RID: 19426 RVA: 0x0006ED1C File Offset: 0x0006CF1C
		public vtkStringArray GetNodeSetIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetNodeSetIdMapAsString_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BE3 RID: 19427
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetNodeSetSelection_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BE4 RID: 19428 RVA: 0x0006ED8C File Offset: 0x0006CF8C
		public vtkDataArraySelection GetNodeSetSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetNodeSetSelection_67(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BE5 RID: 19429
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_GetNumberOfFileNames_68(HandleRef pThis);

		/// <summary>
		/// API to set the filenames.
		/// </summary>
		// Token: 0x06004BE6 RID: 19430 RVA: 0x0006EDFC File Offset: 0x0006CFFC
		public int GetNumberOfFileNames()
		{
			return vtkIOSSReader.vtkIOSSReader_GetNumberOfFileNames_68(base.GetCppThis());
		}

		// Token: 0x06004BE7 RID: 19431
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIOSSReader_GetNumberOfGenerationsFromBase_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004BE8 RID: 19432 RVA: 0x0006EE1C File Offset: 0x0006D01C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIOSSReader.vtkIOSSReader_GetNumberOfGenerationsFromBase_69(base.GetCppThis(), type);
		}

		// Token: 0x06004BE9 RID: 19433
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIOSSReader_GetNumberOfGenerationsFromBaseType_70([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004BEA RID: 19434 RVA: 0x0006EE3C File Offset: 0x0006D03C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIOSSReader.vtkIOSSReader_GetNumberOfGenerationsFromBaseType_70(type);
		}

		// Token: 0x06004BEB RID: 19435
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_GetNumberOfSelectors_71(HandleRef pThis);

		/// <summary>
		/// API to access selectors.
		/// </summary>
		// Token: 0x06004BEC RID: 19436 RVA: 0x0006EE58 File Offset: 0x0006D058
		public int GetNumberOfSelectors()
		{
			return vtkIOSSReader.vtkIOSSReader_GetNumberOfSelectors_71(base.GetCppThis());
		}

		// Token: 0x06004BED RID: 19437
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetReadAllFilesToDetermineStructure_72(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read all files to determine structure of the
		/// dataset because some files might have certain blocks that other files don't have.
		/// Set to false if you are sure that all files have the same structure, i.e. same blocks and sets.
		///
		/// @note When set to false, the reader will only read the first file to determine the structure.
		/// which is faster than reading all files.
		/// </summary>
		// Token: 0x06004BEE RID: 19438 RVA: 0x0006EE78 File Offset: 0x0006D078
		public virtual bool GetReadAllFilesToDetermineStructure()
		{
			return vtkIOSSReader.vtkIOSSReader_GetReadAllFilesToDetermineStructure_72(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BEF RID: 19439
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetReadGlobalFields_73(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read global fields.
		/// </summary>
		// Token: 0x06004BF0 RID: 19440 RVA: 0x0006EEA0 File Offset: 0x0006D0A0
		public virtual bool GetReadGlobalFields()
		{
			return vtkIOSSReader.vtkIOSSReader_GetReadGlobalFields_73(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BF1 RID: 19441
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetReadIds_74(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read ids associated with
		/// elements.
		/// </summary>
		// Token: 0x06004BF2 RID: 19442 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
		public virtual bool GetReadIds()
		{
			return vtkIOSSReader.vtkIOSSReader_GetReadIds_74(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BF3 RID: 19443
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetReadQAAndInformationRecords_75(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read quality assurance and
		/// information fields.
		/// </summary>
		// Token: 0x06004BF4 RID: 19444 RVA: 0x0006EEF0 File Offset: 0x0006D0F0
		public virtual bool GetReadQAAndInformationRecords()
		{
			return vtkIOSSReader.vtkIOSSReader_GetReadQAAndInformationRecords_75(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BF5 RID: 19445
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetRemoveUnusedPoints_76(HandleRef pThis);

		/// <summary>
		/// Node related data, including point coordinates, point field data etc. is
		/// typically shared between all blocks and sets. By default, the reader will
		/// remove unused points for each block or set. To avoid this, set this flag to
		/// false.
		///
		/// Default is true, unused points are removed.
		/// </summary>
		// Token: 0x06004BF6 RID: 19446 RVA: 0x0006EF18 File Offset: 0x0006D118
		public virtual bool GetRemoveUnusedPoints()
		{
			return vtkIOSSReader.vtkIOSSReader_GetRemoveUnusedPoints_76(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BF7 RID: 19447
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSReader_GetScanForRelatedFiles_77(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader can automatically locate and load additional
		/// files that are part of the collection.
		/// </summary>
		// Token: 0x06004BF8 RID: 19448 RVA: 0x0006EF40 File Offset: 0x0006D140
		public virtual bool GetScanForRelatedFiles()
		{
			return vtkIOSSReader.vtkIOSSReader_GetScanForRelatedFiles_77(base.GetCppThis()) != 0;
		}

		// Token: 0x06004BF9 RID: 19449
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetSelector_78(HandleRef pThis, int index);

		/// <summary>
		/// API to access selectors.
		/// </summary>
		// Token: 0x06004BFA RID: 19450 RVA: 0x0006EF68 File Offset: 0x0006D168
		public string GetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSReader.vtkIOSSReader_GetSelector_78(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004BFB RID: 19451
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetSideSetFieldSelection_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004BFC RID: 19452 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
		public vtkDataArraySelection GetSideSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetSideSetFieldSelection_79(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BFD RID: 19453
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetSideSetIdMapAsString_80(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004BFE RID: 19454 RVA: 0x0006F014 File Offset: 0x0006D214
		public vtkStringArray GetSideSetIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetSideSetIdMapAsString_80(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004BFF RID: 19455
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetSideSetSelection_81(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C00 RID: 19456 RVA: 0x0006F084 File Offset: 0x0006D284
		public vtkDataArraySelection GetSideSetSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetSideSetSelection_81(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004C01 RID: 19457
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetStructuredBlockFieldSelection_82(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C02 RID: 19458 RVA: 0x0006F0F4 File Offset: 0x0006D2F4
		public vtkDataArraySelection GetStructuredBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetStructuredBlockFieldSelection_82(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004C03 RID: 19459
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetStructuredBlockIdMapAsString_83(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This API is not really meant for public use and may change without notices.
		/// It is simply provided to make it easy to wrap the API in client-server
		/// wrappings for ParaView.
		/// </summary>
		// Token: 0x06004C04 RID: 19460 RVA: 0x0006F164 File Offset: 0x0006D364
		public vtkStringArray GetStructuredBlockIdMapAsString()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetStructuredBlockIdMapAsString_83(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004C05 RID: 19461
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_GetStructuredBlockSelection_84(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C06 RID: 19462 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		public vtkDataArraySelection GetStructuredBlockSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_GetStructuredBlockSelection_84(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004C07 RID: 19463
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_IsA_85(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004C08 RID: 19464 RVA: 0x0006F244 File Offset: 0x0006D444
		public override int IsA(string type)
		{
			return vtkIOSSReader.vtkIOSSReader_IsA_85(base.GetCppThis(), type);
		}

		// Token: 0x06004C09 RID: 19465
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_IsTypeOf_86([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004C0A RID: 19466 RVA: 0x0006F264 File Offset: 0x0006D464
		public new static int IsTypeOf(string type)
		{
			return vtkIOSSReader.vtkIOSSReader_IsTypeOf_86(type);
		}

		// Token: 0x06004C0B RID: 19467
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_MergeExodusEntityBlocksOff_87(HandleRef pThis);

		/// <summary>
		/// When this flag is on, blocks/sets of like exodus types will be merged.
		///
		/// Note: This flag is ignored for non-exodus data.
		/// </summary>
		// Token: 0x06004C0C RID: 19468 RVA: 0x0006F27E File Offset: 0x0006D47E
		public virtual void MergeExodusEntityBlocksOff()
		{
			vtkIOSSReader.vtkIOSSReader_MergeExodusEntityBlocksOff_87(base.GetCppThis());
		}

		// Token: 0x06004C0D RID: 19469
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_MergeExodusEntityBlocksOn_88(HandleRef pThis);

		/// <summary>
		/// When this flag is on, blocks/sets of like exodus types will be merged.
		///
		/// Note: This flag is ignored for non-exodus data.
		/// </summary>
		// Token: 0x06004C0E RID: 19470 RVA: 0x0006F28D File Offset: 0x0006D48D
		public virtual void MergeExodusEntityBlocksOn()
		{
			vtkIOSSReader.vtkIOSSReader_MergeExodusEntityBlocksOn_88(base.GetCppThis());
		}

		// Token: 0x06004C0F RID: 19471
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_NewInstance_90(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004C10 RID: 19472 RVA: 0x0006F29C File Offset: 0x0006D49C
		public new vtkIOSSReader NewInstance()
		{
			vtkIOSSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_NewInstance_90(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIOSSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004C11 RID: 19473
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadAllFilesToDetermineStructureOff_91(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read all files to determine structure of the
		/// dataset because some files might have certain blocks that other files don't have.
		/// Set to false if you are sure that all files have the same structure, i.e. same blocks and sets.
		///
		/// @note When set to false, the reader will only read the first file to determine the structure.
		/// which is faster than reading all files.
		/// </summary>
		// Token: 0x06004C12 RID: 19474 RVA: 0x0006F2F6 File Offset: 0x0006D4F6
		public virtual void ReadAllFilesToDetermineStructureOff()
		{
			vtkIOSSReader.vtkIOSSReader_ReadAllFilesToDetermineStructureOff_91(base.GetCppThis());
		}

		// Token: 0x06004C13 RID: 19475
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadAllFilesToDetermineStructureOn_92(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read all files to determine structure of the
		/// dataset because some files might have certain blocks that other files don't have.
		/// Set to false if you are sure that all files have the same structure, i.e. same blocks and sets.
		///
		/// @note When set to false, the reader will only read the first file to determine the structure.
		/// which is faster than reading all files.
		/// </summary>
		// Token: 0x06004C14 RID: 19476 RVA: 0x0006F305 File Offset: 0x0006D505
		public virtual void ReadAllFilesToDetermineStructureOn()
		{
			vtkIOSSReader.vtkIOSSReader_ReadAllFilesToDetermineStructureOn_92(base.GetCppThis());
		}

		// Token: 0x06004C15 RID: 19477
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_ReadArrays_93(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

		/// <summary>
		/// Implementation for vtkReaderAlgorithm API
		/// </summary>
		// Token: 0x06004C16 RID: 19478 RVA: 0x0006F314 File Offset: 0x0006D514
		public override int ReadArrays(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
		{
			return vtkIOSSReader.vtkIOSSReader_ReadArrays_93(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x06004C17 RID: 19479
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadGlobalFieldsOff_94(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read global fields.
		/// </summary>
		// Token: 0x06004C18 RID: 19480 RVA: 0x0006F34F File Offset: 0x0006D54F
		public virtual void ReadGlobalFieldsOff()
		{
			vtkIOSSReader.vtkIOSSReader_ReadGlobalFieldsOff_94(base.GetCppThis());
		}

		// Token: 0x06004C19 RID: 19481
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadGlobalFieldsOn_95(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read global fields.
		/// </summary>
		// Token: 0x06004C1A RID: 19482 RVA: 0x0006F35E File Offset: 0x0006D55E
		public virtual void ReadGlobalFieldsOn()
		{
			vtkIOSSReader.vtkIOSSReader_ReadGlobalFieldsOn_95(base.GetCppThis());
		}

		// Token: 0x06004C1B RID: 19483
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadIdsOff_96(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read ids associated with
		/// elements.
		/// </summary>
		// Token: 0x06004C1C RID: 19484 RVA: 0x0006F36D File Offset: 0x0006D56D
		public virtual void ReadIdsOff()
		{
			vtkIOSSReader.vtkIOSSReader_ReadIdsOff_96(base.GetCppThis());
		}

		// Token: 0x06004C1D RID: 19485
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadIdsOn_97(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read ids associated with
		/// elements.
		/// </summary>
		// Token: 0x06004C1E RID: 19486 RVA: 0x0006F37C File Offset: 0x0006D57C
		public virtual void ReadIdsOn()
		{
			vtkIOSSReader.vtkIOSSReader_ReadIdsOn_97(base.GetCppThis());
		}

		// Token: 0x06004C1F RID: 19487
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_ReadMesh_98(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

		/// <summary>
		/// Implementation for vtkReaderAlgorithm API
		/// </summary>
		// Token: 0x06004C20 RID: 19488 RVA: 0x0006F38C File Offset: 0x0006D58C
		public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
		{
			return vtkIOSSReader.vtkIOSSReader_ReadMesh_98(base.GetCppThis(), piece, npieces, nghosts, timestep, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06004C21 RID: 19489
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_ReadMetaData_99(HandleRef pThis, HandleRef metadata);

		/// <summary>
		/// Implementation for vtkReaderAlgorithm API
		/// </summary>
		// Token: 0x06004C22 RID: 19490 RVA: 0x0006F3C8 File Offset: 0x0006D5C8
		public override int ReadMetaData(vtkInformation metadata)
		{
			return vtkIOSSReader.vtkIOSSReader_ReadMetaData_99(base.GetCppThis(), (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06004C23 RID: 19491
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSReader_ReadPoints_100(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

		/// <summary>
		/// Implementation for vtkReaderAlgorithm API
		/// </summary>
		// Token: 0x06004C24 RID: 19492 RVA: 0x0006F3FC File Offset: 0x0006D5FC
		public override int ReadPoints(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
		{
			return vtkIOSSReader.vtkIOSSReader_ReadPoints_100(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x06004C25 RID: 19493
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadQAAndInformationRecordsOff_101(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read quality assurance and
		/// information fields.
		/// </summary>
		// Token: 0x06004C26 RID: 19494 RVA: 0x0006F437 File Offset: 0x0006D637
		public virtual void ReadQAAndInformationRecordsOff()
		{
			vtkIOSSReader.vtkIOSSReader_ReadQAAndInformationRecordsOff_101(base.GetCppThis());
		}

		// Token: 0x06004C27 RID: 19495
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ReadQAAndInformationRecordsOn_102(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the reader will read quality assurance and
		/// information fields.
		/// </summary>
		// Token: 0x06004C28 RID: 19496 RVA: 0x0006F446 File Offset: 0x0006D646
		public virtual void ReadQAAndInformationRecordsOn()
		{
			vtkIOSSReader.vtkIOSSReader_ReadQAAndInformationRecordsOn_102(base.GetCppThis());
		}

		// Token: 0x06004C29 RID: 19497
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_RemoveAllEntitySelections_103(HandleRef pThis);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C2A RID: 19498 RVA: 0x0006F455 File Offset: 0x0006D655
		public void RemoveAllEntitySelections()
		{
			vtkIOSSReader.vtkIOSSReader_RemoveAllEntitySelections_103(base.GetCppThis());
		}

		// Token: 0x06004C2B RID: 19499
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_RemoveAllFieldSelections_104(HandleRef pThis);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C2C RID: 19500 RVA: 0x0006F464 File Offset: 0x0006D664
		public void RemoveAllFieldSelections()
		{
			vtkIOSSReader.vtkIOSSReader_RemoveAllFieldSelections_104(base.GetCppThis());
		}

		// Token: 0x06004C2D RID: 19501
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_RemoveAllSelections_105(HandleRef pThis);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C2E RID: 19502 RVA: 0x0006F473 File Offset: 0x0006D673
		public void RemoveAllSelections()
		{
			vtkIOSSReader.vtkIOSSReader_RemoveAllSelections_105(base.GetCppThis());
		}

		// Token: 0x06004C2F RID: 19503
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_RemoveProperty_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x06004C30 RID: 19504 RVA: 0x0006F482 File Offset: 0x0006D682
		public void RemoveProperty(string name)
		{
			vtkIOSSReader.vtkIOSSReader_RemoveProperty_106(base.GetCppThis(), name);
		}

		// Token: 0x06004C31 RID: 19505
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_RemoveUnusedPointsOff_107(HandleRef pThis);

		/// <summary>
		/// Node related data, including point coordinates, point field data etc. is
		/// typically shared between all blocks and sets. By default, the reader will
		/// remove unused points for each block or set. To avoid this, set this flag to
		/// false.
		///
		/// Default is true, unused points are removed.
		/// </summary>
		// Token: 0x06004C32 RID: 19506 RVA: 0x0006F492 File Offset: 0x0006D692
		public virtual void RemoveUnusedPointsOff()
		{
			vtkIOSSReader.vtkIOSSReader_RemoveUnusedPointsOff_107(base.GetCppThis());
		}

		// Token: 0x06004C33 RID: 19507
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_RemoveUnusedPointsOn_108(HandleRef pThis);

		/// <summary>
		/// Node related data, including point coordinates, point field data etc. is
		/// typically shared between all blocks and sets. By default, the reader will
		/// remove unused points for each block or set. To avoid this, set this flag to
		/// false.
		///
		/// Default is true, unused points are removed.
		/// </summary>
		// Token: 0x06004C34 RID: 19508 RVA: 0x0006F4A1 File Offset: 0x0006D6A1
		public virtual void RemoveUnusedPointsOn()
		{
			vtkIOSSReader.vtkIOSSReader_RemoveUnusedPointsOn_108(base.GetCppThis());
		}

		// Token: 0x06004C35 RID: 19509
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSReader_SafeDownCast_109(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004C36 RID: 19510 RVA: 0x0006F4B0 File Offset: 0x0006D6B0
		public new static vtkIOSSReader SafeDownCast(vtkObjectBase o)
		{
			vtkIOSSReader vtkIOSSReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSReader.vtkIOSSReader_SafeDownCast_109((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIOSSReader = (vtkIOSSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIOSSReader.Register(null);
				}
			}
			return vtkIOSSReader;
		}

		// Token: 0x06004C37 RID: 19511
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ScanForRelatedFilesOff_110(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader can automatically locate and load additional
		/// files that are part of the collection.
		/// </summary>
		// Token: 0x06004C38 RID: 19512 RVA: 0x0006F52F File Offset: 0x0006D72F
		public virtual void ScanForRelatedFilesOff()
		{
			vtkIOSSReader.vtkIOSSReader_ScanForRelatedFilesOff_110(base.GetCppThis());
		}

		// Token: 0x06004C39 RID: 19513
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_ScanForRelatedFilesOn_111(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader can automatically locate and load additional
		/// files that are part of the collection.
		/// </summary>
		// Token: 0x06004C3A RID: 19514 RVA: 0x0006F53E File Offset: 0x0006D73E
		public virtual void ScanForRelatedFilesOn()
		{
			vtkIOSSReader.vtkIOSSReader_ScanForRelatedFilesOn_111(base.GetCppThis());
		}

		// Token: 0x06004C3B RID: 19515
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetApplyDisplacements_112(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), if an array named 'displacement' is present in
		/// the node field arrays, it will be used to transform the point coordinates.
		/// </summary>
		// Token: 0x06004C3C RID: 19516 RVA: 0x0006F54D File Offset: 0x0006D74D
		public virtual void SetApplyDisplacements(bool _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetApplyDisplacements_112(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C3D RID: 19517
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetController_113(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the controller to use when working in parallel. Initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		///
		/// The controller is used to using `ReadMetaData` stage to distribute the work
		/// of gathering meta-data from multiple files, if any, across ranks and then
		/// exchanging that information between all ranks.
		///
		/// The actual reading of data is controlled by piece requests sent by the
		/// pipeline e.g. using `vtkAlgorithm::UpdatePiece`.
		/// </summary>
		// Token: 0x06004C3E RID: 19518 RVA: 0x0006F568 File Offset: 0x0006D768
		public void SetController(vtkMultiProcessController controller)
		{
			vtkIOSSReader.vtkIOSSReader_SetController_113(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x06004C3F RID: 19519
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetDatabaseTypeOverride_114(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the IOSS database name to use for reading the file. If not
		/// specified (default), the reader will determine based on the file extension.
		/// </summary>
		// Token: 0x06004C40 RID: 19520 RVA: 0x0006F597 File Offset: 0x0006D797
		public virtual void SetDatabaseTypeOverride(string _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetDatabaseTypeOverride_114(base.GetCppThis(), _arg);
		}

		// Token: 0x06004C41 RID: 19521
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetDisplacementMagnitude_115(HandleRef pThis, double magnitude);

		/// <summary>
		/// When displacements are being applied, they are scaled by this amount. Set to 1 (default) for no
		/// scaling.
		/// </summary>
		// Token: 0x06004C42 RID: 19522 RVA: 0x0006F5A7 File Offset: 0x0006D7A7
		public void SetDisplacementMagnitude(double magnitude)
		{
			vtkIOSSReader.vtkIOSSReader_SetDisplacementMagnitude_115(base.GetCppThis(), magnitude);
		}

		// Token: 0x06004C43 RID: 19523
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetElementAndSideIds_116(HandleRef pThis, byte value);

		/// <summary>
		/// When this flag is on and MergeExodusEntityBlocks is off,
		/// side sets of exodus data will be annotated with field-data
		/// arrays holding the element-id and side-id for each output cell.
		///
		/// This flag is true/on by default.
		///
		/// Note: This flag is ignored for non-exodus data and when
		/// MergeExodusEntityBlocks is enabled.
		/// </summary>
		// Token: 0x06004C44 RID: 19524 RVA: 0x0006F5B7 File Offset: 0x0006D7B7
		public void SetElementAndSideIds(bool value)
		{
			vtkIOSSReader.vtkIOSSReader_SetElementAndSideIds_116(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C45 RID: 19525
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetFieldSuffixSeparator_117(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Set the character used to separate suffix from the field.
		/// </summary>
		// Token: 0x06004C46 RID: 19526 RVA: 0x0006F5CF File Offset: 0x0006D7CF
		public void SetFieldSuffixSeparator(string value)
		{
			vtkIOSSReader.vtkIOSSReader_SetFieldSuffixSeparator_117(base.GetCppThis(), value);
		}

		// Token: 0x06004C47 RID: 19527
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetFileName_118(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Set a single filename. Note, this will clear all existing filenames.
		/// </summary>
		// Token: 0x06004C48 RID: 19528 RVA: 0x0006F5DF File Offset: 0x0006D7DF
		public void SetFileName(string fname)
		{
			vtkIOSSReader.vtkIOSSReader_SetFileName_118(base.GetCppThis(), fname);
		}

		// Token: 0x06004C49 RID: 19529
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetFileRange_119(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004C4A RID: 19530 RVA: 0x0006F5EF File Offset: 0x0006D7EF
		public virtual void SetFileRange(int _arg1, int _arg2)
		{
			vtkIOSSReader.vtkIOSSReader_SetFileRange_119(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06004C4B RID: 19531
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetFileRange_120(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004C4C RID: 19532 RVA: 0x0006F600 File Offset: 0x0006D800
		public void SetFileRange(IntPtr _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetFileRange_120(base.GetCppThis(), _arg);
		}

		// Token: 0x06004C4D RID: 19533
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetFileStride_121(HandleRef pThis, int _arg);

		/// <summary>
		/// This provides a mechanism to limit to reading to certain files in a
		/// spatially partitioned file-series. To just specific subset of files, one can
		/// always simply specify those files using `AddFileName` and then set
		/// `ScanForRelatedFiles` to false. Another way is to let the reader scan for all
		/// related files and then use `FileRange` and `FileStride` to limit which
		/// files are read.
		///
		/// If the range is invalid, i.e. `FileRange[0] &gt;= FileRange[1]`, it's assumed
		/// that no file-range overrides have been specified and both FileRange and
		/// FileStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004C4E RID: 19534 RVA: 0x0006F610 File Offset: 0x0006D810
		public virtual void SetFileStride(int _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetFileStride_121(base.GetCppThis(), _arg);
		}

		// Token: 0x06004C4F RID: 19535
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetGenerateFileId_122(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true, the reader will add a cell-data array for cells named
		/// 'file_id' which identifies the file number when reading spatially
		/// partitioned files.
		///
		/// Default is false.
		/// </summary>
		// Token: 0x06004C50 RID: 19536 RVA: 0x0006F620 File Offset: 0x0006D820
		public virtual void SetGenerateFileId(bool _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetGenerateFileId_122(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C51 RID: 19537
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetGroupNumericVectorFieldComponents_123(HandleRef pThis, byte value);

		/// <summary>
		/// Set whether the reader should treat numeric suffixes for a vector field as vector components.
		/// By default, this property is off.
		/// Example: DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4
		/// If the property is true, those fields will be parsed as a 4-component vtkDataArray
		/// named DENSITY.
		/// When turned off, DENSITY_1, DENSITY_2, DENSITY_3, DENSITY_4 fields will be parsed as 4
		/// vtkDataArrays with 1 component each.
		/// </summary>
		// Token: 0x06004C52 RID: 19538 RVA: 0x0006F638 File Offset: 0x0006D838
		public void SetGroupNumericVectorFieldComponents(bool value)
		{
			vtkIOSSReader.vtkIOSSReader_SetGroupNumericVectorFieldComponents_123(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C53 RID: 19539
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetMergeExodusEntityBlocks_124(HandleRef pThis, byte value);

		/// <summary>
		/// When this flag is on, blocks/sets of like exodus types will be merged.
		///
		/// Note: This flag is ignored for non-exodus data.
		/// </summary>
		// Token: 0x06004C54 RID: 19540 RVA: 0x0006F650 File Offset: 0x0006D850
		public void SetMergeExodusEntityBlocks(bool value)
		{
			vtkIOSSReader.vtkIOSSReader_SetMergeExodusEntityBlocks_124(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C55 RID: 19541
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetReadAllFilesToDetermineStructure_125(HandleRef pThis, byte arg0);

		/// <summary>
		/// When set to true (default), the reader will read all files to determine structure of the
		/// dataset because some files might have certain blocks that other files don't have.
		/// Set to false if you are sure that all files have the same structure, i.e. same blocks and sets.
		///
		/// @note When set to false, the reader will only read the first file to determine the structure.
		/// which is faster than reading all files.
		/// </summary>
		// Token: 0x06004C56 RID: 19542 RVA: 0x0006F668 File Offset: 0x0006D868
		public void SetReadAllFilesToDetermineStructure(bool arg0)
		{
			vtkIOSSReader.vtkIOSSReader_SetReadAllFilesToDetermineStructure_125(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C57 RID: 19543
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetReadGlobalFields_126(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), the reader will read global fields.
		/// </summary>
		// Token: 0x06004C58 RID: 19544 RVA: 0x0006F680 File Offset: 0x0006D880
		public virtual void SetReadGlobalFields(bool _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetReadGlobalFields_126(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C59 RID: 19545
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetReadIds_127(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), the reader will read ids associated with
		/// elements.
		/// </summary>
		// Token: 0x06004C5A RID: 19546 RVA: 0x0006F698 File Offset: 0x0006D898
		public virtual void SetReadIds(bool _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetReadIds_127(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C5B RID: 19547
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetReadQAAndInformationRecords_128(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), the reader will read quality assurance and
		/// information fields.
		/// </summary>
		// Token: 0x06004C5C RID: 19548 RVA: 0x0006F6B0 File Offset: 0x0006D8B0
		public virtual void SetReadQAAndInformationRecords(bool _arg)
		{
			vtkIOSSReader.vtkIOSSReader_SetReadQAAndInformationRecords_128(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C5D RID: 19549
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetRemoveUnusedPoints_129(HandleRef pThis, byte arg0);

		/// <summary>
		/// Node related data, including point coordinates, point field data etc. is
		/// typically shared between all blocks and sets. By default, the reader will
		/// remove unused points for each block or set. To avoid this, set this flag to
		/// false.
		///
		/// Default is true, unused points are removed.
		/// </summary>
		// Token: 0x06004C5E RID: 19550 RVA: 0x0006F6C8 File Offset: 0x0006D8C8
		public void SetRemoveUnusedPoints(bool arg0)
		{
			vtkIOSSReader.vtkIOSSReader_SetRemoveUnusedPoints_129(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C5F RID: 19551
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetScanForRelatedFiles_130(HandleRef pThis, byte value);

		/// <summary>
		/// When set to true, the reader can automatically locate and load additional
		/// files that are part of the collection.
		/// </summary>
		// Token: 0x06004C60 RID: 19552 RVA: 0x0006F6E0 File Offset: 0x0006D8E0
		public void SetScanForRelatedFiles(bool value)
		{
			vtkIOSSReader.vtkIOSSReader_SetScanForRelatedFiles_130(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x06004C61 RID: 19553
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSReader_SetSelector_131(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// API to specify selectors that indicate which branches on the assembly are
		/// chosen.
		/// </summary>
		// Token: 0x06004C62 RID: 19554 RVA: 0x0006F6F8 File Offset: 0x0006D8F8
		public void SetSelector(string selector)
		{
			vtkIOSSReader.vtkIOSSReader_SetSelector_131(base.GetCppThis(), selector);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000763 RID: 1891
		public new const string MRFullTypeName = "Kitware.VTK.vtkIOSSReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000764 RID: 1892
		public new static readonly string MRClassNameKey = "class vtkIOSSReader";

		/// <summary>
		/// IOSS databases support various properties that affect how the database is
		/// read. These properties can be set using this API. Note, it's best to call
		/// this before the first update to the reader since any change and the reader
		/// will flush all caches and close all open databases etc.
		/// </summary>
		// Token: 0x0200018A RID: 394
		public enum EntityType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000766 RID: 1894
			BLOCK_END = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000767 RID: 1895
			BLOCK_START = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000768 RID: 1896
			EDGEBLOCK,
			/// <summary>enum member</summary>
			// Token: 0x04000769 RID: 1897
			EDGESET = 6,
			/// <summary>enum member</summary>
			// Token: 0x0400076A RID: 1898
			ELEMENTBLOCK = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400076B RID: 1899
			ELEMENTSET = 8,
			/// <summary>enum member</summary>
			// Token: 0x0400076C RID: 1900
			ENTITY_END = 10,
			/// <summary>enum member</summary>
			// Token: 0x0400076D RID: 1901
			ENTITY_START = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400076E RID: 1902
			FACEBLOCK = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400076F RID: 1903
			FACESET = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000770 RID: 1904
			NODEBLOCK = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000771 RID: 1905
			NODESET = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000772 RID: 1906
			NUMBER_OF_ENTITY_TYPES = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000773 RID: 1907
			SET_END = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000774 RID: 1908
			SET_START = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000775 RID: 1909
			SIDESET = 9,
			/// <summary>enum member</summary>
			// Token: 0x04000776 RID: 1910
			STRUCTUREDBLOCK = 4
		}
	}
}
