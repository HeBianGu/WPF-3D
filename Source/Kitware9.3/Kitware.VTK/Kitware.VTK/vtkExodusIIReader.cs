using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExodusIIReader
	/// </summary>
	/// <remarks>
	///    Read exodus 2 files .ex2
	///
	/// vtkExodusIIReader is a unstructured grid source object that reads ExodusII
	/// files.  Most of the meta data associated with the file is loaded when
	/// UpdateInformation is called.  This includes information like Title, number
	/// of blocks, number and names of arrays. This data can be retrieved from
	/// methods in this reader. Separate arrays that are meant to be a single
	/// vector, are combined internally for convenience.  To be combined, the array
	/// names have to be identical except for a trailing X,Y and Z (or x,y,z).  By
	/// default cell and point arrays are not loaded.  However, the user can flag
	/// arrays to load with the methods "SetPointResultArrayStatus" and
	/// "SetElementResultArrayStatus".  The reader DOES NOT respond to piece requests
	///
	/// </remarks>
	// Token: 0x020001B8 RID: 440
	public class vtkExodusIIReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005466 RID: 21606 RVA: 0x0007AEF3 File Offset: 0x000790F3
		static vtkExodusIIReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIIReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005467 RID: 21607 RVA: 0x0007AF1B File Offset: 0x0007911B
		public vtkExodusIIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005468 RID: 21608
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005469 RID: 21609 RVA: 0x0007AF2C File Offset: 0x0007912C
		public new static vtkExodusIIReader New()
		{
			vtkExodusIIReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600546A RID: 21610 RVA: 0x0007AF80 File Offset: 0x00079180
		public vtkExodusIIReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExodusIIReader.vtkExodusIIReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600546B RID: 21611 RVA: 0x0007AFC4 File Offset: 0x000791C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600546C RID: 21612
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_AnimateModeShapesOff_01(HandleRef pThis);

		/// <summary>
		/// If this flag is on (the default) and HasModeShapes is also on, then this
		/// reader will report a continuous time range [0,1] and animate the
		/// displacements in a periodic sinusoid.  If this flag is off and
		/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
		/// HasModeShapes is off.
		/// </summary>
		// Token: 0x0600546D RID: 21613 RVA: 0x0007AFCF File Offset: 0x000791CF
		public virtual void AnimateModeShapesOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_AnimateModeShapesOff_01(base.GetCppThis());
		}

		// Token: 0x0600546E RID: 21614
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_AnimateModeShapesOn_02(HandleRef pThis);

		/// <summary>
		/// If this flag is on (the default) and HasModeShapes is also on, then this
		/// reader will report a continuous time range [0,1] and animate the
		/// displacements in a periodic sinusoid.  If this flag is off and
		/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
		/// HasModeShapes is off.
		/// </summary>
		// Token: 0x0600546F RID: 21615 RVA: 0x0007AFDE File Offset: 0x000791DE
		public virtual void AnimateModeShapesOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_AnimateModeShapesOn_02(base.GetCppThis());
		}

		// Token: 0x06005470 RID: 21616
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_ApplyDisplacementsOff_03(HandleRef pThis);

		/// <summary>
		/// Geometric locations can include displacements.  By default,
		/// this is ON.  The nodal positions are 'displaced' by the
		/// standard exodus displacement vector. If displacements
		/// are turned 'off', the user can explicitly add them by
		/// applying a warp filter.
		/// </summary>
		// Token: 0x06005471 RID: 21617 RVA: 0x0007AFED File Offset: 0x000791ED
		public virtual void ApplyDisplacementsOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_ApplyDisplacementsOff_03(base.GetCppThis());
		}

		// Token: 0x06005472 RID: 21618
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_ApplyDisplacementsOn_04(HandleRef pThis);

		/// <summary>
		/// Geometric locations can include displacements.  By default,
		/// this is ON.  The nodal positions are 'displaced' by the
		/// standard exodus displacement vector. If displacements
		/// are turned 'off', the user can explicitly add them by
		/// applying a warp filter.
		/// </summary>
		// Token: 0x06005473 RID: 21619 RVA: 0x0007AFFC File Offset: 0x000791FC
		public virtual void ApplyDisplacementsOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_ApplyDisplacementsOn_04(base.GetCppThis());
		}

		// Token: 0x06005474 RID: 21620
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_CanReadFile_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Determine if the file can be read with this reader.
		/// </summary>
		// Token: 0x06005475 RID: 21621 RVA: 0x0007B00C File Offset: 0x0007920C
		public virtual int CanReadFile(string fname)
		{
			return vtkExodusIIReader.vtkExodusIIReader_CanReadFile_05(base.GetCppThis(), fname);
		}

		// Token: 0x06005476 RID: 21622
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_Dump_06(HandleRef pThis);

		/// <summary>
		/// Should the reader output only points used by elements in the output mesh,
		/// or all the points. Outputting all the points is much faster since the
		/// point array can be read straight from disk and the mesh connectivity need
		/// not be altered. Squeezing the points down to the minimum set needed to
		/// produce the output mesh is useful for glyphing and other point-based
		/// operations. On large parallel datasets, loading all the points implies
		/// loading all the points on all processes and performing subsequent
		/// filtering on a much larger set.
		///
		/// By default, SqueezePoints is true for backwards compatibility.
		/// </summary>
		// Token: 0x06005477 RID: 21623 RVA: 0x0007B02C File Offset: 0x0007922C
		public virtual void Dump()
		{
			vtkExodusIIReader.vtkExodusIIReader_Dump_06(base.GetCppThis());
		}

		// Token: 0x06005478 RID: 21624
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GLOBAL_TEMPORAL_VARIABLE_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Exodus reader outputs global variables and global temporal variables,
		/// together with some other variables as FieldData. These keys help identify
		/// which arrays in the FieldData are GLOBAL and which ones are
		/// GLOBAL_TEMPORAL.
		///
		/// @sa vtkExtractExodusGlobalTemporalVariables.
		/// </summary>
		// Token: 0x06005479 RID: 21625 RVA: 0x0007B03C File Offset: 0x0007923C
		public static vtkInformationIntegerKey GLOBAL_TEMPORAL_VARIABLE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GLOBAL_TEMPORAL_VARIABLE_07(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600547A RID: 21626
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GLOBAL_VARIABLE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Exodus reader outputs global variables and global temporal variables,
		/// together with some other variables as FieldData. These keys help identify
		/// which arrays in the FieldData are GLOBAL and which ones are
		/// GLOBAL_TEMPORAL.
		///
		/// @sa vtkExtractExodusGlobalTemporalVariables.
		/// </summary>
		// Token: 0x0600547B RID: 21627 RVA: 0x0007B0A8 File Offset: 0x000792A8
		public static vtkInformationIntegerKey GLOBAL_VARIABLE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GLOBAL_VARIABLE_08(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600547C RID: 21628
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateFileIdArrayOff_09(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600547D RID: 21629 RVA: 0x0007B111 File Offset: 0x00079311
		public virtual void GenerateFileIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateFileIdArrayOff_09(base.GetCppThis());
		}

		// Token: 0x0600547E RID: 21630
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateFileIdArrayOn_10(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600547F RID: 21631 RVA: 0x0007B120 File Offset: 0x00079320
		public virtual void GenerateFileIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateFileIdArrayOn_10(base.GetCppThis());
		}

		// Token: 0x06005480 RID: 21632
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateGlobalElementIdArrayOff_11(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005481 RID: 21633 RVA: 0x0007B12F File Offset: 0x0007932F
		public virtual void GenerateGlobalElementIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalElementIdArrayOff_11(base.GetCppThis());
		}

		// Token: 0x06005482 RID: 21634
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateGlobalElementIdArrayOn_12(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005483 RID: 21635 RVA: 0x0007B13E File Offset: 0x0007933E
		public virtual void GenerateGlobalElementIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalElementIdArrayOn_12(base.GetCppThis());
		}

		// Token: 0x06005484 RID: 21636
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateGlobalNodeIdArrayOff_13(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005485 RID: 21637 RVA: 0x0007B14D File Offset: 0x0007934D
		public virtual void GenerateGlobalNodeIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalNodeIdArrayOff_13(base.GetCppThis());
		}

		// Token: 0x06005486 RID: 21638
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateGlobalNodeIdArrayOn_14(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005487 RID: 21639 RVA: 0x0007B15C File Offset: 0x0007935C
		public virtual void GenerateGlobalNodeIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateGlobalNodeIdArrayOn_14(base.GetCppThis());
		}

		// Token: 0x06005488 RID: 21640
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateImplicitElementIdArrayOff_15(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005489 RID: 21641 RVA: 0x0007B16B File Offset: 0x0007936B
		public virtual void GenerateImplicitElementIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitElementIdArrayOff_15(base.GetCppThis());
		}

		// Token: 0x0600548A RID: 21642
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateImplicitElementIdArrayOn_16(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600548B RID: 21643 RVA: 0x0007B17A File Offset: 0x0007937A
		public virtual void GenerateImplicitElementIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitElementIdArrayOn_16(base.GetCppThis());
		}

		// Token: 0x0600548C RID: 21644
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateImplicitNodeIdArrayOff_17(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600548D RID: 21645 RVA: 0x0007B189 File Offset: 0x00079389
		public virtual void GenerateImplicitNodeIdArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitNodeIdArrayOff_17(base.GetCppThis());
		}

		// Token: 0x0600548E RID: 21646
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateImplicitNodeIdArrayOn_18(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600548F RID: 21647 RVA: 0x0007B198 File Offset: 0x00079398
		public virtual void GenerateImplicitNodeIdArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateImplicitNodeIdArrayOn_18(base.GetCppThis());
		}

		// Token: 0x06005490 RID: 21648
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateObjectIdCellArrayOff_19(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005491 RID: 21649 RVA: 0x0007B1A7 File Offset: 0x000793A7
		public virtual void GenerateObjectIdCellArrayOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateObjectIdCellArrayOff_19(base.GetCppThis());
		}

		// Token: 0x06005492 RID: 21650
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GenerateObjectIdCellArrayOn_20(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005493 RID: 21651 RVA: 0x0007B1B6 File Offset: 0x000793B6
		public virtual void GenerateObjectIdCellArrayOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_GenerateObjectIdCellArrayOn_20(base.GetCppThis());
		}

		// Token: 0x06005494 RID: 21652
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetAnimateModeShapes_21(HandleRef pThis);

		/// <summary>
		/// If this flag is on (the default) and HasModeShapes is also on, then this
		/// reader will report a continuous time range [0,1] and animate the
		/// displacements in a periodic sinusoid.  If this flag is off and
		/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
		/// HasModeShapes is off.
		/// </summary>
		// Token: 0x06005495 RID: 21653 RVA: 0x0007B1C8 File Offset: 0x000793C8
		public int GetAnimateModeShapes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAnimateModeShapes_21(base.GetCppThis());
		}

		// Token: 0x06005496 RID: 21654
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetApplyDisplacements_22(HandleRef pThis);

		/// <summary>
		/// Geometric locations can include displacements.  By default,
		/// this is ON.  The nodal positions are 'displaced' by the
		/// standard exodus displacement vector. If displacements
		/// are turned 'off', the user can explicitly add them by
		/// applying a warp filter.
		/// </summary>
		// Token: 0x06005497 RID: 21655 RVA: 0x0007B1E8 File Offset: 0x000793E8
		public int GetApplyDisplacements()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetApplyDisplacements_22(base.GetCppThis());
		}

		// Token: 0x06005498 RID: 21656
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetAssemblyArrayID_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x06005499 RID: 21657 RVA: 0x0007B208 File Offset: 0x00079408
		public int GetAssemblyArrayID(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayID_23(base.GetCppThis(), name);
		}

		// Token: 0x0600549A RID: 21658
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetAssemblyArrayName_24(HandleRef pThis, int arrayIdx);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x0600549B RID: 21659 RVA: 0x0007B228 File Offset: 0x00079428
		public string GetAssemblyArrayName(int arrayIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayName_24(base.GetCppThis(), arrayIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600549C RID: 21660
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetAssemblyArrayStatus_25(HandleRef pThis, int index);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x0600549D RID: 21661 RVA: 0x0007B264 File Offset: 0x00079464
		public int GetAssemblyArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayStatus_25(base.GetCppThis(), index);
		}

		// Token: 0x0600549E RID: 21662
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetAssemblyArrayStatus_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x0600549F RID: 21663 RVA: 0x0007B284 File Offset: 0x00079484
		public int GetAssemblyArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetAssemblyArrayStatus_26(base.GetCppThis(), arg0);
		}

		// Token: 0x060054A0 RID: 21664
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExodusIIReader_GetCacheSize_27(HandleRef pThis);

		/// <summary>
		/// Get the size of the cache in MiB.
		/// </summary>
		// Token: 0x060054A1 RID: 21665 RVA: 0x0007B2A4 File Offset: 0x000794A4
		public double GetCacheSize()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetCacheSize_27(base.GetCppThis());
		}

		// Token: 0x060054A2 RID: 21666
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetDimensionality_28(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060054A3 RID: 21667 RVA: 0x0007B2C4 File Offset: 0x000794C4
		public int GetDimensionality()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetDimensionality_28(base.GetCppThis());
		}

		// Token: 0x060054A4 RID: 21668
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkExodusIIReader_GetDisplacementMagnitude_29(HandleRef pThis);

		/// <summary>
		/// Geometric locations can include displacements.  By default,
		/// this is ON.  The nodal positions are 'displaced' by the
		/// standard exodus displacement vector. If displacements
		/// are turned 'off', the user can explicitly add them by
		/// applying a warp filter.
		/// </summary>
		// Token: 0x060054A5 RID: 21669 RVA: 0x0007B2E4 File Offset: 0x000794E4
		public float GetDisplacementMagnitude()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetDisplacementMagnitude_29(base.GetCppThis());
		}

		// Token: 0x060054A6 RID: 21670
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetDisplayType_30(HandleRef pThis);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x060054A7 RID: 21671 RVA: 0x0007B304 File Offset: 0x00079504
		public virtual int GetDisplayType()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetDisplayType_30(base.GetCppThis());
		}

		// Token: 0x060054A8 RID: 21672
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeBlockArrayName_31(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054A9 RID: 21673 RVA: 0x0007B324 File Offset: 0x00079524
		public string GetEdgeBlockArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeBlockArrayName_31(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054AA RID: 21674
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetEdgeBlockArrayStatus_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054AB RID: 21675 RVA: 0x0007B360 File Offset: 0x00079560
		public int GetEdgeBlockArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeBlockArrayStatus_32(base.GetCppThis(), name);
		}

		// Token: 0x060054AC RID: 21676
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeMapArrayName_33(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054AD RID: 21677 RVA: 0x0007B380 File Offset: 0x00079580
		public string GetEdgeMapArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeMapArrayName_33(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054AE RID: 21678
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetEdgeMapArrayStatus_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054AF RID: 21679 RVA: 0x0007B3BC File Offset: 0x000795BC
		public int GetEdgeMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeMapArrayStatus_34(base.GetCppThis(), name);
		}

		// Token: 0x060054B0 RID: 21680
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeResultArrayName_35(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054B1 RID: 21681 RVA: 0x0007B3DC File Offset: 0x000795DC
		public string GetEdgeResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeResultArrayName_35(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054B2 RID: 21682
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetEdgeResultArrayStatus_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054B3 RID: 21683 RVA: 0x0007B418 File Offset: 0x00079618
		public int GetEdgeResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeResultArrayStatus_36(base.GetCppThis(), name);
		}

		// Token: 0x060054B4 RID: 21684
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeSetArrayName_37(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054B5 RID: 21685 RVA: 0x0007B438 File Offset: 0x00079638
		public string GetEdgeSetArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetArrayName_37(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054B6 RID: 21686
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetEdgeSetArrayStatus_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054B7 RID: 21687 RVA: 0x0007B474 File Offset: 0x00079674
		public int GetEdgeSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetArrayStatus_38(base.GetCppThis(), name);
		}

		// Token: 0x060054B8 RID: 21688
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetEdgeSetResultArrayName_39(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054B9 RID: 21689 RVA: 0x0007B494 File Offset: 0x00079694
		public string GetEdgeSetResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetResultArrayName_39(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054BA RID: 21690
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetEdgeSetResultArrayStatus_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054BB RID: 21691 RVA: 0x0007B4D0 File Offset: 0x000796D0
		public int GetEdgeSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetEdgeSetResultArrayStatus_40(base.GetCppThis(), name);
		}

		// Token: 0x060054BC RID: 21692
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetElementBlockArrayName_41(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054BD RID: 21693 RVA: 0x0007B4F0 File Offset: 0x000796F0
		public string GetElementBlockArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementBlockArrayName_41(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054BE RID: 21694
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetElementBlockArrayStatus_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054BF RID: 21695 RVA: 0x0007B52C File Offset: 0x0007972C
		public int GetElementBlockArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementBlockArrayStatus_42(base.GetCppThis(), name);
		}

		// Token: 0x060054C0 RID: 21696
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetElementMapArrayName_43(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054C1 RID: 21697 RVA: 0x0007B54C File Offset: 0x0007974C
		public string GetElementMapArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementMapArrayName_43(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054C2 RID: 21698
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetElementMapArrayStatus_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054C3 RID: 21699 RVA: 0x0007B588 File Offset: 0x00079788
		public int GetElementMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementMapArrayStatus_44(base.GetCppThis(), name);
		}

		// Token: 0x060054C4 RID: 21700
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetElementResultArrayName_45(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054C5 RID: 21701 RVA: 0x0007B5A8 File Offset: 0x000797A8
		public string GetElementResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementResultArrayName_45(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054C6 RID: 21702
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetElementResultArrayStatus_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054C7 RID: 21703 RVA: 0x0007B5E4 File Offset: 0x000797E4
		public int GetElementResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementResultArrayStatus_46(base.GetCppThis(), name);
		}

		// Token: 0x060054C8 RID: 21704
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetElementSetArrayName_47(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054C9 RID: 21705 RVA: 0x0007B604 File Offset: 0x00079804
		public string GetElementSetArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementSetArrayName_47(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054CA RID: 21706
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetElementSetArrayStatus_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054CB RID: 21707 RVA: 0x0007B640 File Offset: 0x00079840
		public int GetElementSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementSetArrayStatus_48(base.GetCppThis(), name);
		}

		// Token: 0x060054CC RID: 21708
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetElementSetResultArrayName_49(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054CD RID: 21709 RVA: 0x0007B660 File Offset: 0x00079860
		public string GetElementSetResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetElementSetResultArrayName_49(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054CE RID: 21710
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetElementSetResultArrayStatus_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054CF RID: 21711 RVA: 0x0007B69C File Offset: 0x0007989C
		public int GetElementSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetElementSetResultArrayStatus_50(base.GetCppThis(), name);
		}

		// Token: 0x060054D0 RID: 21712
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetFaceBlockArrayName_51(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054D1 RID: 21713 RVA: 0x0007B6BC File Offset: 0x000798BC
		public string GetFaceBlockArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceBlockArrayName_51(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054D2 RID: 21714
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetFaceBlockArrayStatus_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054D3 RID: 21715 RVA: 0x0007B6F8 File Offset: 0x000798F8
		public int GetFaceBlockArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceBlockArrayStatus_52(base.GetCppThis(), name);
		}

		// Token: 0x060054D4 RID: 21716
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetFaceMapArrayName_53(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054D5 RID: 21717 RVA: 0x0007B718 File Offset: 0x00079918
		public string GetFaceMapArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceMapArrayName_53(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054D6 RID: 21718
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetFaceMapArrayStatus_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054D7 RID: 21719 RVA: 0x0007B754 File Offset: 0x00079954
		public int GetFaceMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceMapArrayStatus_54(base.GetCppThis(), name);
		}

		// Token: 0x060054D8 RID: 21720
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetFaceResultArrayName_55(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054D9 RID: 21721 RVA: 0x0007B774 File Offset: 0x00079974
		public string GetFaceResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceResultArrayName_55(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054DA RID: 21722
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetFaceResultArrayStatus_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054DB RID: 21723 RVA: 0x0007B7B0 File Offset: 0x000799B0
		public int GetFaceResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceResultArrayStatus_56(base.GetCppThis(), name);
		}

		// Token: 0x060054DC RID: 21724
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetFaceSetArrayName_57(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054DD RID: 21725 RVA: 0x0007B7D0 File Offset: 0x000799D0
		public string GetFaceSetArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceSetArrayName_57(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054DE RID: 21726
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetFaceSetArrayStatus_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054DF RID: 21727 RVA: 0x0007B80C File Offset: 0x00079A0C
		public int GetFaceSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceSetArrayStatus_58(base.GetCppThis(), name);
		}

		// Token: 0x060054E0 RID: 21728
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetFaceSetResultArrayName_59(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054E1 RID: 21729 RVA: 0x0007B82C File Offset: 0x00079A2C
		public string GetFaceSetResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFaceSetResultArrayName_59(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054E2 RID: 21730
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetFaceSetResultArrayStatus_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060054E3 RID: 21731 RVA: 0x0007B868 File Offset: 0x00079A68
		public int GetFaceSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFaceSetResultArrayStatus_60(base.GetCppThis(), name);
		}

		// Token: 0x060054E4 RID: 21732
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetFileId_61(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054E5 RID: 21733 RVA: 0x0007B888 File Offset: 0x00079A88
		public int GetFileId()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetFileId_61(base.GetCppThis());
		}

		// Token: 0x060054E6 RID: 21734
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetFileName_62(HandleRef pThis);

		/// <summary>
		/// Specify file name of the Exodus file.
		/// </summary>
		// Token: 0x060054E7 RID: 21735 RVA: 0x0007B8A8 File Offset: 0x00079AA8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetFileName_62(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054E8 RID: 21736
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGenerateFileIdArray_63(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054E9 RID: 21737 RVA: 0x0007B8E4 File Offset: 0x00079AE4
		public int GetGenerateFileIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateFileIdArray_63(base.GetCppThis());
		}

		// Token: 0x060054EA RID: 21738
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGenerateGlobalElementIdArray_64(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054EB RID: 21739 RVA: 0x0007B904 File Offset: 0x00079B04
		public int GetGenerateGlobalElementIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateGlobalElementIdArray_64(base.GetCppThis());
		}

		// Token: 0x060054EC RID: 21740
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGenerateGlobalNodeIdArray_65(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054ED RID: 21741 RVA: 0x0007B924 File Offset: 0x00079B24
		public int GetGenerateGlobalNodeIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateGlobalNodeIdArray_65(base.GetCppThis());
		}

		// Token: 0x060054EE RID: 21742
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGenerateImplicitElementIdArray_66(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054EF RID: 21743 RVA: 0x0007B944 File Offset: 0x00079B44
		public int GetGenerateImplicitElementIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateImplicitElementIdArray_66(base.GetCppThis());
		}

		// Token: 0x060054F0 RID: 21744
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGenerateImplicitNodeIdArray_67(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054F1 RID: 21745 RVA: 0x0007B964 File Offset: 0x00079B64
		public int GetGenerateImplicitNodeIdArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateImplicitNodeIdArray_67(base.GetCppThis());
		}

		// Token: 0x060054F2 RID: 21746
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGenerateObjectIdCellArray_68(HandleRef pThis);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060054F3 RID: 21747 RVA: 0x0007B984 File Offset: 0x00079B84
		public int GetGenerateObjectIdCellArray()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGenerateObjectIdCellArray_68(base.GetCppThis());
		}

		// Token: 0x060054F4 RID: 21748
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalEdgeID_69(HandleRef data, int localID);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060054F5 RID: 21749 RVA: 0x0007B9A4 File Offset: 0x00079BA4
		public static int GetGlobalEdgeID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalEdgeID_69((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		// Token: 0x060054F6 RID: 21750
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalEdgeID_70(HandleRef data, int localID, int searchType);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060054F7 RID: 21751 RVA: 0x0007B9D4 File Offset: 0x00079BD4
		public static int GetGlobalEdgeID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalEdgeID_70((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		// Token: 0x060054F8 RID: 21752
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalEdgeIdArrayName_71();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060054F9 RID: 21753 RVA: 0x0007BA04 File Offset: 0x00079C04
		public static string GetGlobalEdgeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalEdgeIdArrayName_71());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060054FA RID: 21754
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalElementID_72(HandleRef data, int localID);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060054FB RID: 21755 RVA: 0x0007BA38 File Offset: 0x00079C38
		public static int GetGlobalElementID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalElementID_72((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		// Token: 0x060054FC RID: 21756
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalElementID_73(HandleRef data, int localID, int searchType);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060054FD RID: 21757 RVA: 0x0007BA68 File Offset: 0x00079C68
		public static int GetGlobalElementID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalElementID_73((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		// Token: 0x060054FE RID: 21758
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalElementIdArrayName_74();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060054FF RID: 21759 RVA: 0x0007BA98 File Offset: 0x00079C98
		public static string GetGlobalElementIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalElementIdArrayName_74());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005500 RID: 21760
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalFaceID_75(HandleRef data, int localID);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x06005501 RID: 21761 RVA: 0x0007BACC File Offset: 0x00079CCC
		public static int GetGlobalFaceID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalFaceID_75((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		// Token: 0x06005502 RID: 21762
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalFaceID_76(HandleRef data, int localID, int searchType);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x06005503 RID: 21763 RVA: 0x0007BAFC File Offset: 0x00079CFC
		public static int GetGlobalFaceID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalFaceID_76((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		// Token: 0x06005504 RID: 21764
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalFaceIdArrayName_77();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x06005505 RID: 21765 RVA: 0x0007BB2C File Offset: 0x00079D2C
		public static string GetGlobalFaceIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalFaceIdArrayName_77());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005506 RID: 21766
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalNodeID_78(HandleRef data, int localID);

		/// <summary>
		/// Extra point data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id of the node.
		/// The id is relative to the entire data set.
		/// The name of the array is returned by GlobalNodeIdArrayName().
		/// </summary>
		// Token: 0x06005507 RID: 21767 RVA: 0x0007BB60 File Offset: 0x00079D60
		public static int GetGlobalNodeID(vtkDataSet data, int localID)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalNodeID_78((data == null) ? default(HandleRef) : data.GetCppThis(), localID);
		}

		// Token: 0x06005508 RID: 21768
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalNodeID_79(HandleRef data, int localID, int searchType);

		/// <summary>
		/// Extra point data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id of the node.
		/// The id is relative to the entire data set.
		/// The name of the array is returned by GlobalNodeIdArrayName().
		/// </summary>
		// Token: 0x06005509 RID: 21769 RVA: 0x0007BB90 File Offset: 0x00079D90
		public static int GetGlobalNodeID(vtkDataSet data, int localID, int searchType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalNodeID_79((data == null) ? default(HandleRef) : data.GetCppThis(), localID, searchType);
		}

		// Token: 0x0600550A RID: 21770
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalNodeIdArrayName_80();

		/// <summary>
		/// Extra point data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id of the node.
		/// The id is relative to the entire data set.
		/// The name of the array is returned by GlobalNodeIdArrayName().
		/// </summary>
		// Token: 0x0600550B RID: 21771 RVA: 0x0007BBC0 File Offset: 0x00079DC0
		public static string GetGlobalNodeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalNodeIdArrayName_80());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600550C RID: 21772
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetGlobalResultArrayName_81(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600550D RID: 21773 RVA: 0x0007BBF4 File Offset: 0x00079DF4
		public string GetGlobalResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetGlobalResultArrayName_81(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600550E RID: 21774
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetGlobalResultArrayStatus_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600550F RID: 21775 RVA: 0x0007BC30 File Offset: 0x00079E30
		public int GetGlobalResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetGlobalResultArrayStatus_82(base.GetCppThis(), name);
		}

		// Token: 0x06005510 RID: 21776
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetHasModeShapes_83(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
		/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
		/// in which case it is true.
		/// </summary>
		// Token: 0x06005511 RID: 21777 RVA: 0x0007BC50 File Offset: 0x00079E50
		public int GetHasModeShapes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetHasModeShapes_83(base.GetCppThis());
		}

		// Token: 0x06005512 RID: 21778
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetHierarchyArrayName_84(HandleRef pThis, int arrayIdx);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x06005513 RID: 21779 RVA: 0x0007BC70 File Offset: 0x00079E70
		public string GetHierarchyArrayName(int arrayIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetHierarchyArrayName_84(base.GetCppThis(), arrayIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005514 RID: 21780
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetHierarchyArrayStatus_85(HandleRef pThis, int index);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x06005515 RID: 21781 RVA: 0x0007BCAC File Offset: 0x00079EAC
		public int GetHierarchyArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetHierarchyArrayStatus_85(base.GetCppThis(), index);
		}

		// Token: 0x06005516 RID: 21782
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetHierarchyArrayStatus_86(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x06005517 RID: 21783 RVA: 0x0007BCCC File Offset: 0x00079ECC
		public int GetHierarchyArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetHierarchyArrayStatus_86(base.GetCppThis(), arg0);
		}

		// Token: 0x06005518 RID: 21784
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExodusIIReader_GetIgnoreFileTime_87(HandleRef pThis);

		/// <summary>
		/// When on, this option ignores the time values assigned to each time step in
		/// the file. This can be useful for Exodus files where different time steps
		/// are overloaded to represent different aspects of a data set rather than the
		/// data set at different time values.
		/// </summary>
		// Token: 0x06005519 RID: 21785 RVA: 0x0007BCEC File Offset: 0x00079EEC
		public bool GetIgnoreFileTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetIgnoreFileTime_87(base.GetCppThis()) != 0;
		}

		// Token: 0x0600551A RID: 21786
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitEdgeIdArrayName_88();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x0600551B RID: 21787 RVA: 0x0007BD14 File Offset: 0x00079F14
		public static string GetImplicitEdgeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitEdgeIdArrayName_88());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600551C RID: 21788
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitElementIdArrayName_89();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x0600551D RID: 21789 RVA: 0x0007BD48 File Offset: 0x00079F48
		public static string GetImplicitElementIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitElementIdArrayName_89());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600551E RID: 21790
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitFaceIdArrayName_90();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x0600551F RID: 21791 RVA: 0x0007BD7C File Offset: 0x00079F7C
		public static string GetImplicitFaceIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitFaceIdArrayName_90());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005520 RID: 21792
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetImplicitNodeIdArrayName_91();

		/// <summary>
		/// Extra point data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id of the node.
		/// The id is relative to the entire data set.
		/// The name of the array is returned by GlobalNodeIdArrayName().
		/// </summary>
		// Token: 0x06005521 RID: 21793 RVA: 0x0007BDB0 File Offset: 0x00079FB0
		public static string GetImplicitNodeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetImplicitNodeIdArrayName_91());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005522 RID: 21794
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExodusIIReader_GetMTime_92(HandleRef pThis);

		/// <summary>
		/// Return the object's MTime. This is overridden to include the timestamp of its internal class.
		/// </summary>
		// Token: 0x06005523 RID: 21795 RVA: 0x0007BDE4 File Offset: 0x00079FE4
		public override ulong GetMTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMTime_92(base.GetCppThis());
		}

		// Token: 0x06005524 RID: 21796
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetMaterialArrayID_93(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x06005525 RID: 21797 RVA: 0x0007BE04 File Offset: 0x0007A004
		public int GetMaterialArrayID(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayID_93(base.GetCppThis(), name);
		}

		// Token: 0x06005526 RID: 21798
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetMaterialArrayName_94(HandleRef pThis, int arrayIdx);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x06005527 RID: 21799 RVA: 0x0007BE24 File Offset: 0x0007A024
		public string GetMaterialArrayName(int arrayIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayName_94(base.GetCppThis(), arrayIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005528 RID: 21800
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetMaterialArrayStatus_95(HandleRef pThis, int index);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x06005529 RID: 21801 RVA: 0x0007BE60 File Offset: 0x0007A060
		public int GetMaterialArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayStatus_95(base.GetCppThis(), index);
		}

		// Token: 0x0600552A RID: 21802
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetMaterialArrayStatus_96(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x0600552B RID: 21803 RVA: 0x0007BE80 File Offset: 0x0007A080
		public int GetMaterialArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaterialArrayStatus_96(base.GetCppThis(), arg0);
		}

		// Token: 0x0600552C RID: 21804
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetMaxNameLength_97(HandleRef pThis);

		/// <summary>
		/// Get the max_name_length in the file. This is the amount of space allocated
		/// int the file for storing names of arrays, blocks, etc.
		/// </summary>
		// Token: 0x0600552D RID: 21805 RVA: 0x0007BEA0 File Offset: 0x0007A0A0
		public int GetMaxNameLength()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMaxNameLength_97(base.GetCppThis());
		}

		// Token: 0x0600552E RID: 21806
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExodusIIReader_GetMetadataMTime_98(HandleRef pThis);

		/// <summary>
		/// Return the MTime of the internal data structure.
		/// This is really only intended for use by vtkPExodusIIReader in order
		/// to determine if the filename is newer than the metadata.
		/// </summary>
		// Token: 0x0600552F RID: 21807 RVA: 0x0007BEC0 File Offset: 0x0007A0C0
		public virtual ulong GetMetadataMTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetMetadataMTime_98(base.GetCppThis());
		}

		// Token: 0x06005530 RID: 21808
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExodusIIReader_GetModeShapeTime_99(HandleRef pThis);

		/// <summary>
		/// Set/Get the time used to animate mode shapes.
		/// This is a number between 0 and 1 that is used to scale the \a DisplacementMagnitude
		/// in a sinusoidal pattern. Specifically, the displacement vector for each vertex is scaled by
		/// \f$ \mathrm{DisplacementMagnitude} cos( 2\pi \mathrm{ModeShapeTime} ) \f$ before it is
		/// added to the vertex coordinates.
		/// </summary>
		// Token: 0x06005531 RID: 21809 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
		public double GetModeShapeTime()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetModeShapeTime_99(base.GetCppThis());
		}

		// Token: 0x06005532 RID: 21810
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetModeShapesRange_100(HandleRef pThis);

		/// <summary>
		/// Since ModeShapes are expected to run from [1,N] rather than [0, N-1],
		/// this method will return the TimeStepRange offset by 1. Note this method
		/// returns the potential mode shapes range irrespective of whether
		/// this-&gt;HasModeShapes is set to true.
		/// </summary>
		// Token: 0x06005533 RID: 21811 RVA: 0x0007BF00 File Offset: 0x0007A100
		public virtual int[] GetModeShapesRange()
		{
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GetModeShapesRange_100(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005534 RID: 21812
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GetModeShapesRange_101(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Since ModeShapes are expected to run from [1,N] rather than [0, N-1],
		/// this method will return the TimeStepRange offset by 1. Note this method
		/// returns the potential mode shapes range irrespective of whether
		/// this-&gt;HasModeShapes is set to true.
		/// </summary>
		// Token: 0x06005535 RID: 21813 RVA: 0x0007BF48 File Offset: 0x0007A148
		public virtual void GetModeShapesRange(ref int _arg1, ref int _arg2)
		{
			vtkExodusIIReader.vtkExodusIIReader_GetModeShapesRange_101(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06005536 RID: 21814
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GetModeShapesRange_102(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Since ModeShapes are expected to run from [1,N] rather than [0, N-1],
		/// this method will return the TimeStepRange offset by 1. Note this method
		/// returns the potential mode shapes range irrespective of whether
		/// this-&gt;HasModeShapes is set to true.
		/// </summary>
		// Token: 0x06005537 RID: 21815 RVA: 0x0007BF59 File Offset: 0x0007A159
		public virtual void GetModeShapesRange(IntPtr _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_GetModeShapesRange_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06005538 RID: 21816
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetNodeMapArrayName_103(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005539 RID: 21817 RVA: 0x0007BF6C File Offset: 0x0007A16C
		public string GetNodeMapArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetNodeMapArrayName_103(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600553A RID: 21818
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNodeMapArrayStatus_104(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600553B RID: 21819 RVA: 0x0007BFA8 File Offset: 0x0007A1A8
		public int GetNodeMapArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNodeMapArrayStatus_104(base.GetCppThis(), name);
		}

		// Token: 0x0600553C RID: 21820
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetNodeSetArrayName_105(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600553D RID: 21821 RVA: 0x0007BFC8 File Offset: 0x0007A1C8
		public string GetNodeSetArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetNodeSetArrayName_105(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600553E RID: 21822
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNodeSetArrayStatus_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600553F RID: 21823 RVA: 0x0007C004 File Offset: 0x0007A204
		public int GetNodeSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNodeSetArrayStatus_106(base.GetCppThis(), name);
		}

		// Token: 0x06005540 RID: 21824
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetNodeSetResultArrayName_107(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005541 RID: 21825 RVA: 0x0007C024 File Offset: 0x0007A224
		public string GetNodeSetResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetNodeSetResultArrayName_107(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005542 RID: 21826
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNodeSetResultArrayStatus_108(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005543 RID: 21827 RVA: 0x0007C060 File Offset: 0x0007A260
		public int GetNodeSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNodeSetResultArrayStatus_108(base.GetCppThis(), name);
		}

		// Token: 0x06005544 RID: 21828
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfAssemblyArrays_109(HandleRef pThis);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x06005545 RID: 21829 RVA: 0x0007C080 File Offset: 0x0007A280
		public int GetNumberOfAssemblyArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfAssemblyArrays_109(base.GetCppThis());
		}

		// Token: 0x06005546 RID: 21830
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeBlockArrays_110(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005547 RID: 21831 RVA: 0x0007C0A0 File Offset: 0x0007A2A0
		public int GetNumberOfEdgeBlockArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeBlockArrays_110(base.GetCppThis());
		}

		// Token: 0x06005548 RID: 21832
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeMapArrays_111(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005549 RID: 21833 RVA: 0x0007C0C0 File Offset: 0x0007A2C0
		public int GetNumberOfEdgeMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeMapArrays_111(base.GetCppThis());
		}

		// Token: 0x0600554A RID: 21834
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeResultArrays_112(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600554B RID: 21835 RVA: 0x0007C0E0 File Offset: 0x0007A2E0
		public int GetNumberOfEdgeResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeResultArrays_112(base.GetCppThis());
		}

		// Token: 0x0600554C RID: 21836
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeSetArrays_113(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600554D RID: 21837 RVA: 0x0007C100 File Offset: 0x0007A300
		public int GetNumberOfEdgeSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeSetArrays_113(base.GetCppThis());
		}

		// Token: 0x0600554E RID: 21838
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgeSetResultArrays_114(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600554F RID: 21839 RVA: 0x0007C120 File Offset: 0x0007A320
		public int GetNumberOfEdgeSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgeSetResultArrays_114(base.GetCppThis());
		}

		// Token: 0x06005550 RID: 21840
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEdgesInFile_115(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x06005551 RID: 21841 RVA: 0x0007C140 File Offset: 0x0007A340
		public int GetNumberOfEdgesInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEdgesInFile_115(base.GetCppThis());
		}

		// Token: 0x06005552 RID: 21842
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfElementBlockArrays_116(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005553 RID: 21843 RVA: 0x0007C160 File Offset: 0x0007A360
		public int GetNumberOfElementBlockArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementBlockArrays_116(base.GetCppThis());
		}

		// Token: 0x06005554 RID: 21844
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfElementMapArrays_117(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005555 RID: 21845 RVA: 0x0007C180 File Offset: 0x0007A380
		public int GetNumberOfElementMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementMapArrays_117(base.GetCppThis());
		}

		// Token: 0x06005556 RID: 21846
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfElementResultArrays_118(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005557 RID: 21847 RVA: 0x0007C1A0 File Offset: 0x0007A3A0
		public int GetNumberOfElementResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementResultArrays_118(base.GetCppThis());
		}

		// Token: 0x06005558 RID: 21848
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfElementSetArrays_119(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005559 RID: 21849 RVA: 0x0007C1C0 File Offset: 0x0007A3C0
		public int GetNumberOfElementSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementSetArrays_119(base.GetCppThis());
		}

		// Token: 0x0600555A RID: 21850
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfElementSetResultArrays_120(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600555B RID: 21851 RVA: 0x0007C1E0 File Offset: 0x0007A3E0
		public int GetNumberOfElementSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementSetResultArrays_120(base.GetCppThis());
		}

		// Token: 0x0600555C RID: 21852
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfElementsInFile_121(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600555D RID: 21853 RVA: 0x0007C200 File Offset: 0x0007A400
		public int GetNumberOfElementsInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfElementsInFile_121(base.GetCppThis());
		}

		// Token: 0x0600555E RID: 21854
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfEntriesInObject_122(HandleRef pThis, int objectType, int objectIndex);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600555F RID: 21855 RVA: 0x0007C220 File Offset: 0x0007A420
		public int GetNumberOfEntriesInObject(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfEntriesInObject_122(base.GetCppThis(), objectType, objectIndex);
		}

		// Token: 0x06005560 RID: 21856
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceBlockArrays_123(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005561 RID: 21857 RVA: 0x0007C244 File Offset: 0x0007A444
		public int GetNumberOfFaceBlockArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceBlockArrays_123(base.GetCppThis());
		}

		// Token: 0x06005562 RID: 21858
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceMapArrays_124(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005563 RID: 21859 RVA: 0x0007C264 File Offset: 0x0007A464
		public int GetNumberOfFaceMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceMapArrays_124(base.GetCppThis());
		}

		// Token: 0x06005564 RID: 21860
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceResultArrays_125(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005565 RID: 21861 RVA: 0x0007C284 File Offset: 0x0007A484
		public int GetNumberOfFaceResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceResultArrays_125(base.GetCppThis());
		}

		// Token: 0x06005566 RID: 21862
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceSetArrays_126(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005567 RID: 21863 RVA: 0x0007C2A4 File Offset: 0x0007A4A4
		public int GetNumberOfFaceSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceSetArrays_126(base.GetCppThis());
		}

		// Token: 0x06005568 RID: 21864
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfFaceSetResultArrays_127(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005569 RID: 21865 RVA: 0x0007C2C4 File Offset: 0x0007A4C4
		public int GetNumberOfFaceSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFaceSetResultArrays_127(base.GetCppThis());
		}

		// Token: 0x0600556A RID: 21866
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfFacesInFile_128(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600556B RID: 21867 RVA: 0x0007C2E4 File Offset: 0x0007A4E4
		public int GetNumberOfFacesInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfFacesInFile_128(base.GetCppThis());
		}

		// Token: 0x0600556C RID: 21868
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReader_GetNumberOfGenerationsFromBase_129(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600556D RID: 21869 RVA: 0x0007C304 File Offset: 0x0007A504
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfGenerationsFromBase_129(base.GetCppThis(), type);
		}

		// Token: 0x0600556E RID: 21870
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReader_GetNumberOfGenerationsFromBaseType_130([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600556F RID: 21871 RVA: 0x0007C324 File Offset: 0x0007A524
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfGenerationsFromBaseType_130(type);
		}

		// Token: 0x06005570 RID: 21872
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfGlobalResultArrays_131(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005571 RID: 21873 RVA: 0x0007C340 File Offset: 0x0007A540
		public int GetNumberOfGlobalResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfGlobalResultArrays_131(base.GetCppThis());
		}

		// Token: 0x06005572 RID: 21874
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfHierarchyArrays_132(HandleRef pThis);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x06005573 RID: 21875 RVA: 0x0007C360 File Offset: 0x0007A560
		public int GetNumberOfHierarchyArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfHierarchyArrays_132(base.GetCppThis());
		}

		// Token: 0x06005574 RID: 21876
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfMaterialArrays_133(HandleRef pThis);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x06005575 RID: 21877 RVA: 0x0007C380 File Offset: 0x0007A580
		public int GetNumberOfMaterialArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfMaterialArrays_133(base.GetCppThis());
		}

		// Token: 0x06005576 RID: 21878
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfNodeMapArrays_134(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005577 RID: 21879 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
		public int GetNumberOfNodeMapArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodeMapArrays_134(base.GetCppThis());
		}

		// Token: 0x06005578 RID: 21880
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfNodeSetArrays_135(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005579 RID: 21881 RVA: 0x0007C3C0 File Offset: 0x0007A5C0
		public int GetNumberOfNodeSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodeSetArrays_135(base.GetCppThis());
		}

		// Token: 0x0600557A RID: 21882
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfNodeSetResultArrays_136(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600557B RID: 21883 RVA: 0x0007C3E0 File Offset: 0x0007A5E0
		public int GetNumberOfNodeSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodeSetResultArrays_136(base.GetCppThis());
		}

		// Token: 0x0600557C RID: 21884
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfNodes_137(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600557D RID: 21885 RVA: 0x0007C400 File Offset: 0x0007A600
		public int GetNumberOfNodes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodes_137(base.GetCppThis());
		}

		// Token: 0x0600557E RID: 21886
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfNodesInFile_138(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600557F RID: 21887 RVA: 0x0007C420 File Offset: 0x0007A620
		public int GetNumberOfNodesInFile()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfNodesInFile_138(base.GetCppThis());
		}

		// Token: 0x06005580 RID: 21888
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfObjectArrayComponents_139(HandleRef pThis, int objectType, int arrayIndex);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005581 RID: 21889 RVA: 0x0007C440 File Offset: 0x0007A640
		public int GetNumberOfObjectArrayComponents(int objectType, int arrayIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjectArrayComponents_139(base.GetCppThis(), objectType, arrayIndex);
		}

		// Token: 0x06005582 RID: 21890
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfObjectArrays_140(HandleRef pThis, int objectType);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005583 RID: 21891 RVA: 0x0007C464 File Offset: 0x0007A664
		public int GetNumberOfObjectArrays(int objectType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjectArrays_140(base.GetCppThis(), objectType);
		}

		// Token: 0x06005584 RID: 21892
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfObjectAttributes_141(HandleRef pThis, int objectType, int objectIndex);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005585 RID: 21893 RVA: 0x0007C484 File Offset: 0x0007A684
		public int GetNumberOfObjectAttributes(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjectAttributes_141(base.GetCppThis(), objectType, objectIndex);
		}

		// Token: 0x06005586 RID: 21894
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfObjects_142(HandleRef pThis, int objectType);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x06005587 RID: 21895 RVA: 0x0007C4A8 File Offset: 0x0007A6A8
		public int GetNumberOfObjects(int objectType)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfObjects_142(base.GetCppThis(), objectType);
		}

		// Token: 0x06005588 RID: 21896
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfPartArrays_143(HandleRef pThis);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x06005589 RID: 21897 RVA: 0x0007C4C8 File Offset: 0x0007A6C8
		public int GetNumberOfPartArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfPartArrays_143(base.GetCppThis());
		}

		// Token: 0x0600558A RID: 21898
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfPointResultArrays_144(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600558B RID: 21899 RVA: 0x0007C4E8 File Offset: 0x0007A6E8
		public int GetNumberOfPointResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfPointResultArrays_144(base.GetCppThis());
		}

		// Token: 0x0600558C RID: 21900
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfSideSetArrays_145(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600558D RID: 21901 RVA: 0x0007C508 File Offset: 0x0007A708
		public int GetNumberOfSideSetArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfSideSetArrays_145(base.GetCppThis());
		}

		// Token: 0x0600558E RID: 21902
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfSideSetResultArrays_146(HandleRef pThis);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600558F RID: 21903 RVA: 0x0007C528 File Offset: 0x0007A728
		public int GetNumberOfSideSetResultArrays()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfSideSetResultArrays_146(base.GetCppThis());
		}

		// Token: 0x06005590 RID: 21904
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetNumberOfTimeSteps_147(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x06005591 RID: 21905 RVA: 0x0007C548 File Offset: 0x0007A748
		public int GetNumberOfTimeSteps()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetNumberOfTimeSteps_147(base.GetCppThis());
		}

		// Token: 0x06005592 RID: 21906
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectArrayIndex_148(HandleRef pThis, int objectType, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005593 RID: 21907 RVA: 0x0007C568 File Offset: 0x0007A768
		public int GetObjectArrayIndex(int objectType, string arrayName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayIndex_148(base.GetCppThis(), objectType, arrayName);
		}

		// Token: 0x06005594 RID: 21908
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetObjectArrayName_149(HandleRef pThis, int objectType, int arrayIndex);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005595 RID: 21909 RVA: 0x0007C58C File Offset: 0x0007A78C
		public string GetObjectArrayName(int objectType, int arrayIndex)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayName_149(base.GetCppThis(), objectType, arrayIndex));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005596 RID: 21910
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectArrayStatus_150(HandleRef pThis, int objectType, int arrayIndex);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005597 RID: 21911 RVA: 0x0007C5C8 File Offset: 0x0007A7C8
		public int GetObjectArrayStatus(int objectType, int arrayIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayStatus_150(base.GetCppThis(), objectType, arrayIndex);
		}

		// Token: 0x06005598 RID: 21912
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectArrayStatus_151(HandleRef pThis, int objectType, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005599 RID: 21913 RVA: 0x0007C5EC File Offset: 0x0007A7EC
		public int GetObjectArrayStatus(int objectType, string arrayName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectArrayStatus_151(base.GetCppThis(), objectType, arrayName);
		}

		// Token: 0x0600559A RID: 21914
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectAttributeIndex_152(HandleRef pThis, int objectType, int objectIndex, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribName);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x0600559B RID: 21915 RVA: 0x0007C610 File Offset: 0x0007A810
		public int GetObjectAttributeIndex(int objectType, int objectIndex, string attribName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeIndex_152(base.GetCppThis(), objectType, objectIndex, attribName);
		}

		// Token: 0x0600559C RID: 21916
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetObjectAttributeName_153(HandleRef pThis, int objectType, int objectIndex, int attribIndex);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x0600559D RID: 21917 RVA: 0x0007C634 File Offset: 0x0007A834
		public string GetObjectAttributeName(int objectType, int objectIndex, int attribIndex)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeName_153(base.GetCppThis(), objectType, objectIndex, attribIndex));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600559E RID: 21918
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectAttributeStatus_154(HandleRef pThis, int objectType, int objectIndex, int attribIndex);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x0600559F RID: 21919 RVA: 0x0007C674 File Offset: 0x0007A874
		public int GetObjectAttributeStatus(int objectType, int objectIndex, int attribIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeStatus_154(base.GetCppThis(), objectType, objectIndex, attribIndex);
		}

		// Token: 0x060055A0 RID: 21920
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectAttributeStatus_155(HandleRef pThis, int objectType, int objectIndex, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribName);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x060055A1 RID: 21921 RVA: 0x0007C698 File Offset: 0x0007A898
		public int GetObjectAttributeStatus(int objectType, int objectIndex, string attribName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectAttributeStatus_155(base.GetCppThis(), objectType, objectIndex, attribName);
		}

		// Token: 0x060055A2 RID: 21922
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectId_156(HandleRef pThis, int objectType, int objectIndex);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055A3 RID: 21923 RVA: 0x0007C6BC File Offset: 0x0007A8BC
		public int GetObjectId(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectId_156(base.GetCppThis(), objectType, objectIndex);
		}

		// Token: 0x060055A4 RID: 21924
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetObjectIdArrayName_157();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x060055A5 RID: 21925 RVA: 0x0007C6E0 File Offset: 0x0007A8E0
		public static string GetObjectIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectIdArrayName_157());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055A6 RID: 21926
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectIndex_158(HandleRef pThis, int objectType, [MarshalAs(UnmanagedType.LPUTF8Str)] string objectName);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055A7 RID: 21927 RVA: 0x0007C714 File Offset: 0x0007A914
		public int GetObjectIndex(int objectType, string objectName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectIndex_158(base.GetCppThis(), objectType, objectName);
		}

		// Token: 0x060055A8 RID: 21928
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectIndex_159(HandleRef pThis, int objectType, int id);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055A9 RID: 21929 RVA: 0x0007C738 File Offset: 0x0007A938
		public int GetObjectIndex(int objectType, int id)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectIndex_159(base.GetCppThis(), objectType, id);
		}

		// Token: 0x060055AA RID: 21930
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetObjectName_160(HandleRef pThis, int objectType, int objectIndex);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055AB RID: 21931 RVA: 0x0007C75C File Offset: 0x0007A95C
		public string GetObjectName(int objectType, int objectIndex)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectName_160(base.GetCppThis(), objectType, objectIndex));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055AC RID: 21932
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectStatus_161(HandleRef pThis, int objectType, int objectIndex);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055AD RID: 21933 RVA: 0x0007C798 File Offset: 0x0007A998
		public int GetObjectStatus(int objectType, int objectIndex)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectStatus_161(base.GetCppThis(), objectType, objectIndex);
		}

		// Token: 0x060055AE RID: 21934
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectStatus_162(HandleRef pThis, int objectType, [MarshalAs(UnmanagedType.LPUTF8Str)] string objectName);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055AF RID: 21935 RVA: 0x0007C7BC File Offset: 0x0007A9BC
		public int GetObjectStatus(int objectType, string objectName)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectStatus_162(base.GetCppThis(), objectType, objectName);
		}

		// Token: 0x060055B0 RID: 21936
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetObjectTypeFromName_163(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055B1 RID: 21937 RVA: 0x0007C7E0 File Offset: 0x0007A9E0
		public int GetObjectTypeFromName(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetObjectTypeFromName_163(base.GetCppThis(), name);
		}

		// Token: 0x060055B2 RID: 21938
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetObjectTypeName_164(HandleRef pThis, int arg0);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055B3 RID: 21939 RVA: 0x0007C800 File Offset: 0x0007AA00
		public string GetObjectTypeName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetObjectTypeName_164(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055B4 RID: 21940
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetPartArrayID_165(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x060055B5 RID: 21941 RVA: 0x0007C83C File Offset: 0x0007AA3C
		public int GetPartArrayID(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPartArrayID_165(base.GetCppThis(), name);
		}

		// Token: 0x060055B6 RID: 21942
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPartArrayName_166(HandleRef pThis, int arrayIdx);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x060055B7 RID: 21943 RVA: 0x0007C85C File Offset: 0x0007AA5C
		public string GetPartArrayName(int arrayIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPartArrayName_166(base.GetCppThis(), arrayIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055B8 RID: 21944
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetPartArrayStatus_167(HandleRef pThis, int index);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x060055B9 RID: 21945 RVA: 0x0007C898 File Offset: 0x0007AA98
		public int GetPartArrayStatus(int index)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPartArrayStatus_167(base.GetCppThis(), index);
		}

		// Token: 0x060055BA RID: 21946
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetPartArrayStatus_168(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x060055BB RID: 21947 RVA: 0x0007C8B8 File Offset: 0x0007AAB8
		public int GetPartArrayStatus(string arg0)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPartArrayStatus_168(base.GetCppThis(), arg0);
		}

		// Token: 0x060055BC RID: 21948
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPartBlockInfo_169(HandleRef pThis, int arrayIdx);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x060055BD RID: 21949 RVA: 0x0007C8D8 File Offset: 0x0007AAD8
		public string GetPartBlockInfo(int arrayIdx)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPartBlockInfo_169(base.GetCppThis(), arrayIdx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055BE RID: 21950
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeEdgeIdArrayName_170();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060055BF RID: 21951 RVA: 0x0007C914 File Offset: 0x0007AB14
		public static string GetPedigreeEdgeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeEdgeIdArrayName_170());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055C0 RID: 21952
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeElementIdArrayName_171();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060055C1 RID: 21953 RVA: 0x0007C948 File Offset: 0x0007AB48
		public static string GetPedigreeElementIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeElementIdArrayName_171());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055C2 RID: 21954
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeFaceIdArrayName_172();

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x060055C3 RID: 21955 RVA: 0x0007C97C File Offset: 0x0007AB7C
		public static string GetPedigreeFaceIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeFaceIdArrayName_172());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055C4 RID: 21956
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPedigreeNodeIdArrayName_173();

		/// <summary>
		/// Extra point data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id of the node.
		/// The id is relative to the entire data set.
		/// The name of the array is returned by GlobalNodeIdArrayName().
		/// </summary>
		// Token: 0x060055C5 RID: 21957 RVA: 0x0007C9B0 File Offset: 0x0007ABB0
		public static string GetPedigreeNodeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPedigreeNodeIdArrayName_173());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055C6 RID: 21958
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetPointResultArrayName_174(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055C7 RID: 21959 RVA: 0x0007C9E4 File Offset: 0x0007ABE4
		public string GetPointResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetPointResultArrayName_174(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055C8 RID: 21960
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetPointResultArrayStatus_175(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055C9 RID: 21961 RVA: 0x0007CA20 File Offset: 0x0007AC20
		public int GetPointResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetPointResultArrayStatus_175(base.GetCppThis(), name);
		}

		// Token: 0x060055CA RID: 21962
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetSIL_176(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// SIL describes organization of/relationships between classifications
		/// eg. blocks/materials/hierarchies.
		/// </summary>
		// Token: 0x060055CB RID: 21963 RVA: 0x0007CA40 File Offset: 0x0007AC40
		public vtkGraph GetSIL()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GetSIL_176(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x060055CC RID: 21964
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetSILUpdateStamp_177(HandleRef pThis);

		/// <summary>
		/// Every time the SIL is updated a this will return a different value.
		/// </summary>
		// Token: 0x060055CD RID: 21965 RVA: 0x0007CAB0 File Offset: 0x0007ACB0
		public virtual int GetSILUpdateStamp()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSILUpdateStamp_177(base.GetCppThis());
		}

		// Token: 0x060055CE RID: 21966
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetSideSetArrayName_178(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055CF RID: 21967 RVA: 0x0007CAD0 File Offset: 0x0007ACD0
		public string GetSideSetArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetSideSetArrayName_178(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055D0 RID: 21968
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetSideSetArrayStatus_179(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055D1 RID: 21969 RVA: 0x0007CB0C File Offset: 0x0007AD0C
		public int GetSideSetArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSideSetArrayStatus_179(base.GetCppThis(), name);
		}

		// Token: 0x060055D2 RID: 21970
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetSideSetResultArrayName_180(HandleRef pThis, int index);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055D3 RID: 21971 RVA: 0x0007CB2C File Offset: 0x0007AD2C
		public string GetSideSetResultArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetSideSetResultArrayName_180(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055D4 RID: 21972
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetSideSetResultArrayStatus_181(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055D5 RID: 21973 RVA: 0x0007CB68 File Offset: 0x0007AD68
		public int GetSideSetResultArrayStatus(string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSideSetResultArrayStatus_181(base.GetCppThis(), name);
		}

		// Token: 0x060055D6 RID: 21974
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetSideSetSourceElementIdArrayName_182();

		/// <summary>
		/// Get the name of the array that stores the mapping from side set
		/// cells back to the global id of the elements they bound.
		/// </summary>
		// Token: 0x060055D7 RID: 21975 RVA: 0x0007CB88 File Offset: 0x0007AD88
		public static string GetSideSetSourceElementIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetSideSetSourceElementIdArrayName_182());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055D8 RID: 21976
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetSideSetSourceElementSideArrayName_183();

		/// <summary>
		/// Get the name of the array that stores the mapping from side set
		/// cells back to the canonical side of the elements they bound.
		/// </summary>
		// Token: 0x060055D9 RID: 21977 RVA: 0x0007CBBC File Offset: 0x0007ADBC
		public static string GetSideSetSourceElementSideArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetSideSetSourceElementSideArrayName_183());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055DA RID: 21978
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExodusIIReader_GetSqueezePoints_184(HandleRef pThis);

		/// <summary>
		/// Should the reader output only points used by elements in the output mesh,
		/// or all the points. Outputting all the points is much faster since the
		/// point array can be read straight from disk and the mesh connectivity need
		/// not be altered. Squeezing the points down to the minimum set needed to
		/// produce the output mesh is useful for glyphing and other point-based
		/// operations. On large parallel datasets, loading all the points implies
		/// loading all the points on all processes and performing subsequent
		/// filtering on a much larger set.
		///
		/// By default, SqueezePoints is true for backwards compatibility.
		/// </summary>
		// Token: 0x060055DB RID: 21979 RVA: 0x0007CBF0 File Offset: 0x0007ADF0
		public bool GetSqueezePoints()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetSqueezePoints_184(base.GetCppThis()) != 0;
		}

		// Token: 0x060055DC RID: 21980
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetTimeSeriesData_185(HandleRef pThis, int ID, [MarshalAs(UnmanagedType.LPUTF8Str)] string vName, [MarshalAs(UnmanagedType.LPUTF8Str)] string vType, HandleRef result);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055DD RID: 21981 RVA: 0x0007CC18 File Offset: 0x0007AE18
		public int GetTimeSeriesData(int ID, string vName, string vType, vtkFloatArray result)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTimeSeriesData_185(base.GetCppThis(), ID, vName, vType, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x060055DE RID: 21982
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetTimeStep_186(HandleRef pThis);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x060055DF RID: 21983 RVA: 0x0007CC54 File Offset: 0x0007AE54
		public virtual int GetTimeStep()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTimeStep_186(base.GetCppThis());
		}

		// Token: 0x060055E0 RID: 21984
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetTimeStepRange_187(HandleRef pThis);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// Note this method returns the potential timesteps range irrespective of
		/// whether this-&gt;HasModeShapes is set to false.
		/// </summary>
		// Token: 0x060055E1 RID: 21985 RVA: 0x0007CC74 File Offset: 0x0007AE74
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_GetTimeStepRange_187(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060055E2 RID: 21986
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GetTimeStepRange_188(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// Note this method returns the potential timesteps range irrespective of
		/// whether this-&gt;HasModeShapes is set to false.
		/// </summary>
		// Token: 0x060055E3 RID: 21987 RVA: 0x0007CCBC File Offset: 0x0007AEBC
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkExodusIIReader.vtkExodusIIReader_GetTimeStepRange_188(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060055E4 RID: 21988
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_GetTimeStepRange_189(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Returns the available range of valid integer time steps.
		/// Note this method returns the potential timesteps range irrespective of
		/// whether this-&gt;HasModeShapes is set to false.
		/// </summary>
		// Token: 0x060055E5 RID: 21989 RVA: 0x0007CCCD File Offset: 0x0007AECD
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_GetTimeStepRange_189(base.GetCppThis(), _arg);
		}

		// Token: 0x060055E6 RID: 21990
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetTitle_190(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x060055E7 RID: 21991 RVA: 0x0007CCE0 File Offset: 0x0007AEE0
		public string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetTitle_190(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055E8 RID: 21992
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfEdges_191(HandleRef pThis);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x060055E9 RID: 21993 RVA: 0x0007CD1C File Offset: 0x0007AF1C
		public virtual long GetTotalNumberOfEdges()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfEdges_191(base.GetCppThis());
		}

		// Token: 0x060055EA RID: 21994
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfElements_192(HandleRef pThis);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x060055EB RID: 21995 RVA: 0x0007CD3C File Offset: 0x0007AF3C
		public virtual long GetTotalNumberOfElements()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfElements_192(base.GetCppThis());
		}

		// Token: 0x060055EC RID: 21996
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfFaces_193(HandleRef pThis);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x060055ED RID: 21997 RVA: 0x0007CD5C File Offset: 0x0007AF5C
		public virtual long GetTotalNumberOfFaces()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfFaces_193(base.GetCppThis());
		}

		// Token: 0x060055EE RID: 21998
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReader_GetTotalNumberOfNodes_194(HandleRef pThis);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x060055EF RID: 21999 RVA: 0x0007CD7C File Offset: 0x0007AF7C
		public virtual long GetTotalNumberOfNodes()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetTotalNumberOfNodes_194(base.GetCppThis());
		}

		// Token: 0x060055F0 RID: 22000
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExodusIIReader_GetUseLegacyBlockNames_195(HandleRef pThis);

		/// <summary>
		/// In previous versions, the reader added the type of elements in the block to
		/// the block name when no name was provided for the block. This has issues
		/// with consistency when naming blocks across ranks for partitioned files
		/// (see paraview/paraview#19110), hence we no longer do that. For legacy
		/// pipelines, one can enable the old behavior by setting this flag to true.
		/// </summary>
		// Token: 0x060055F1 RID: 22001 RVA: 0x0007CD9C File Offset: 0x0007AF9C
		public virtual bool GetUseLegacyBlockNames()
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetUseLegacyBlockNames_195(base.GetCppThis()) != 0;
		}

		// Token: 0x060055F2 RID: 22002
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_GetVariableID_196(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x060055F3 RID: 22003 RVA: 0x0007CDC4 File Offset: 0x0007AFC4
		public int GetVariableID(string type, string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_GetVariableID_196(base.GetCppThis(), type, name);
		}

		// Token: 0x060055F4 RID: 22004
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_GetXMLFileName_197(HandleRef pThis);

		/// <summary>
		/// Specify file name of the xml file.
		/// </summary>
		// Token: 0x060055F5 RID: 22005 RVA: 0x0007CDE8 File Offset: 0x0007AFE8
		public virtual string GetXMLFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkExodusIIReader.vtkExodusIIReader_GetXMLFileName_197(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060055F6 RID: 22006
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_HasModeShapesOff_198(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
		/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
		/// in which case it is true.
		/// </summary>
		// Token: 0x060055F7 RID: 22007 RVA: 0x0007CE22 File Offset: 0x0007B022
		public virtual void HasModeShapesOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_HasModeShapesOff_198(base.GetCppThis());
		}

		// Token: 0x060055F8 RID: 22008
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_HasModeShapesOn_199(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
		/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
		/// in which case it is true.
		/// </summary>
		// Token: 0x060055F9 RID: 22009 RVA: 0x0007CE31 File Offset: 0x0007B031
		public virtual void HasModeShapesOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_HasModeShapesOn_199(base.GetCppThis());
		}

		// Token: 0x060055FA RID: 22010
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_IgnoreFileTimeOff_200(HandleRef pThis);

		/// <summary>
		/// When on, this option ignores the time values assigned to each time step in
		/// the file. This can be useful for Exodus files where different time steps
		/// are overloaded to represent different aspects of a data set rather than the
		/// data set at different time values.
		/// </summary>
		// Token: 0x060055FB RID: 22011 RVA: 0x0007CE40 File Offset: 0x0007B040
		public virtual void IgnoreFileTimeOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_IgnoreFileTimeOff_200(base.GetCppThis());
		}

		// Token: 0x060055FC RID: 22012
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_IgnoreFileTimeOn_201(HandleRef pThis);

		/// <summary>
		/// When on, this option ignores the time values assigned to each time step in
		/// the file. This can be useful for Exodus files where different time steps
		/// are overloaded to represent different aspects of a data set rather than the
		/// data set at different time values.
		/// </summary>
		// Token: 0x060055FD RID: 22013 RVA: 0x0007CE4F File Offset: 0x0007B04F
		public virtual void IgnoreFileTimeOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_IgnoreFileTimeOn_201(base.GetCppThis());
		}

		// Token: 0x060055FE RID: 22014
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_IsA_202(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060055FF RID: 22015 RVA: 0x0007CE60 File Offset: 0x0007B060
		public override int IsA(string type)
		{
			return vtkExodusIIReader.vtkExodusIIReader_IsA_202(base.GetCppThis(), type);
		}

		// Token: 0x06005600 RID: 22016
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_IsTypeOf_203([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005601 RID: 22017 RVA: 0x0007CE80 File Offset: 0x0007B080
		public new static int IsTypeOf(string type)
		{
			return vtkExodusIIReader.vtkExodusIIReader_IsTypeOf_203(type);
		}

		// Token: 0x06005602 RID: 22018
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReader_IsValidVariable_204(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// return boolean indicating whether the type,name is a valid variable
		/// </summary>
		// Token: 0x06005603 RID: 22019 RVA: 0x0007CE9C File Offset: 0x0007B09C
		public int IsValidVariable(string type, string name)
		{
			return vtkExodusIIReader.vtkExodusIIReader_IsValidVariable_204(base.GetCppThis(), type, name);
		}

		// Token: 0x06005604 RID: 22020
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_NewInstance_206(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005605 RID: 22021 RVA: 0x0007CEC0 File Offset: 0x0007B0C0
		public new vtkExodusIIReader NewInstance()
		{
			vtkExodusIIReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_NewInstance_206(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005606 RID: 22022
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_Reset_207(HandleRef pThis);

		/// <summary>
		/// Reset the user-specified parameters and flush internal arrays
		/// so that the reader state is just as it was after the reader was
		/// instantiated.
		///
		/// It doesn't make sense to let users reset only the internal state;
		/// both the settings and the state are changed by this call.
		/// </summary>
		// Token: 0x06005607 RID: 22023 RVA: 0x0007CF1A File Offset: 0x0007B11A
		public void Reset()
		{
			vtkExodusIIReader.vtkExodusIIReader_Reset_207(base.GetCppThis());
		}

		// Token: 0x06005608 RID: 22024
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_ResetCache_208(HandleRef pThis);

		/// <summary>
		/// Clears out the cache entries.
		/// </summary>
		// Token: 0x06005609 RID: 22025 RVA: 0x0007CF29 File Offset: 0x0007B129
		public void ResetCache()
		{
			vtkExodusIIReader.vtkExodusIIReader_ResetCache_208(base.GetCppThis());
		}

		// Token: 0x0600560A RID: 22026
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_ResetSettings_209(HandleRef pThis);

		/// <summary>
		/// Reset the user-specified parameters to their default values.
		/// The only settings not affected are the filename and/or pattern
		/// because these have no default.
		///
		/// Resetting the settings but not the state allows users to
		/// keep the active cache but return to initial array selections, etc.
		/// </summary>
		// Token: 0x0600560B RID: 22027 RVA: 0x0007CF38 File Offset: 0x0007B138
		public void ResetSettings()
		{
			vtkExodusIIReader.vtkExodusIIReader_ResetSettings_209(base.GetCppThis());
		}

		// Token: 0x0600560C RID: 22028
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReader_SafeDownCast_210(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600560D RID: 22029 RVA: 0x0007CF48 File Offset: 0x0007B148
		public new static vtkExodusIIReader SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIIReader vtkExodusIIReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReader.vtkExodusIIReader_SafeDownCast_210((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIIReader = (vtkExodusIIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIIReader.Register(null);
				}
			}
			return vtkExodusIIReader;
		}

		// Token: 0x0600560E RID: 22030
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetAllArrayStatus_211(HandleRef pThis, int otype, int status);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600560F RID: 22031 RVA: 0x0007CFC7 File Offset: 0x0007B1C7
		public void SetAllArrayStatus(int otype, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAllArrayStatus_211(base.GetCppThis(), otype, status);
		}

		// Token: 0x06005610 RID: 22032
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetAnimateModeShapes_212(HandleRef pThis, int flag);

		/// <summary>
		/// If this flag is on (the default) and HasModeShapes is also on, then this
		/// reader will report a continuous time range [0,1] and animate the
		/// displacements in a periodic sinusoid.  If this flag is off and
		/// HasModeShapes is on, this reader ignores time.  This flag has no effect if
		/// HasModeShapes is off.
		/// </summary>
		// Token: 0x06005611 RID: 22033 RVA: 0x0007CFD8 File Offset: 0x0007B1D8
		public virtual void SetAnimateModeShapes(int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAnimateModeShapes_212(base.GetCppThis(), flag);
		}

		// Token: 0x06005612 RID: 22034
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetApplyDisplacements_213(HandleRef pThis, int d);

		/// <summary>
		/// Geometric locations can include displacements.  By default,
		/// this is ON.  The nodal positions are 'displaced' by the
		/// standard exodus displacement vector. If displacements
		/// are turned 'off', the user can explicitly add them by
		/// applying a warp filter.
		/// </summary>
		// Token: 0x06005613 RID: 22035 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		public virtual void SetApplyDisplacements(int d)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetApplyDisplacements_213(base.GetCppThis(), d);
		}

		// Token: 0x06005614 RID: 22036
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetAssemblyArrayStatus_214(HandleRef pThis, int index, int flag);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x06005615 RID: 22037 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		public void SetAssemblyArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAssemblyArrayStatus_214(base.GetCppThis(), index, flag);
		}

		// Token: 0x06005616 RID: 22038
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetAssemblyArrayStatus_215(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int flag);

		/// <summary>
		/// By default all assemblies are loaded. These methods allow the user to
		/// select which assemblies they want to load.  You can get information
		/// about the assemblies by first calling UpdateInformation, and using
		/// GetAssemblyArrayName ...
		/// </summary>
		// Token: 0x06005617 RID: 22039 RVA: 0x0007D009 File Offset: 0x0007B209
		public void SetAssemblyArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetAssemblyArrayStatus_215(base.GetCppThis(), arg0, flag);
		}

		// Token: 0x06005618 RID: 22040
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetCacheSize_216(HandleRef pThis, double CacheSize);

		/// <summary>
		/// Set the size of the cache in MiB.
		/// </summary>
		// Token: 0x06005619 RID: 22041 RVA: 0x0007D01A File Offset: 0x0007B21A
		public void SetCacheSize(double CacheSize)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetCacheSize_216(base.GetCppThis(), CacheSize);
		}

		// Token: 0x0600561A RID: 22042
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetDisplacementMagnitude_217(HandleRef pThis, float s);

		/// <summary>
		/// Geometric locations can include displacements.  By default,
		/// this is ON.  The nodal positions are 'displaced' by the
		/// standard exodus displacement vector. If displacements
		/// are turned 'off', the user can explicitly add them by
		/// applying a warp filter.
		/// </summary>
		// Token: 0x0600561B RID: 22043 RVA: 0x0007D02A File Offset: 0x0007B22A
		public virtual void SetDisplacementMagnitude(float s)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetDisplacementMagnitude_217(base.GetCppThis(), s);
		}

		// Token: 0x0600561C RID: 22044
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetDisplayType_218(HandleRef pThis, int type);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x0600561D RID: 22045 RVA: 0x0007D03A File Offset: 0x0007B23A
		public virtual void SetDisplayType(int type)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetDisplayType_218(base.GetCppThis(), type);
		}

		// Token: 0x0600561E RID: 22046
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetEdgeBlockArrayStatus_219(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600561F RID: 22047 RVA: 0x0007D04A File Offset: 0x0007B24A
		public void SetEdgeBlockArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeBlockArrayStatus_219(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005620 RID: 22048
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetEdgeMapArrayStatus_220(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005621 RID: 22049 RVA: 0x0007D05B File Offset: 0x0007B25B
		public void SetEdgeMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeMapArrayStatus_220(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005622 RID: 22050
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetEdgeResultArrayStatus_221(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005623 RID: 22051 RVA: 0x0007D06C File Offset: 0x0007B26C
		public void SetEdgeResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeResultArrayStatus_221(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005624 RID: 22052
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetEdgeSetArrayStatus_222(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005625 RID: 22053 RVA: 0x0007D07D File Offset: 0x0007B27D
		public void SetEdgeSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeSetArrayStatus_222(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005626 RID: 22054
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetEdgeSetResultArrayStatus_223(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005627 RID: 22055 RVA: 0x0007D08E File Offset: 0x0007B28E
		public void SetEdgeSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetEdgeSetResultArrayStatus_223(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005628 RID: 22056
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetElementBlockArrayStatus_224(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005629 RID: 22057 RVA: 0x0007D09F File Offset: 0x0007B29F
		public void SetElementBlockArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementBlockArrayStatus_224(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600562A RID: 22058
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetElementMapArrayStatus_225(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600562B RID: 22059 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
		public void SetElementMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementMapArrayStatus_225(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600562C RID: 22060
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetElementResultArrayStatus_226(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600562D RID: 22061 RVA: 0x0007D0C1 File Offset: 0x0007B2C1
		public void SetElementResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementResultArrayStatus_226(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600562E RID: 22062
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetElementSetArrayStatus_227(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600562F RID: 22063 RVA: 0x0007D0D2 File Offset: 0x0007B2D2
		public void SetElementSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementSetArrayStatus_227(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005630 RID: 22064
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetElementSetResultArrayStatus_228(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005631 RID: 22065 RVA: 0x0007D0E3 File Offset: 0x0007B2E3
		public void SetElementSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetElementSetResultArrayStatus_228(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005632 RID: 22066
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFaceBlockArrayStatus_229(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005633 RID: 22067 RVA: 0x0007D0F4 File Offset: 0x0007B2F4
		public void SetFaceBlockArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceBlockArrayStatus_229(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005634 RID: 22068
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFaceMapArrayStatus_230(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005635 RID: 22069 RVA: 0x0007D105 File Offset: 0x0007B305
		public void SetFaceMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceMapArrayStatus_230(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005636 RID: 22070
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFaceResultArrayStatus_231(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005637 RID: 22071 RVA: 0x0007D116 File Offset: 0x0007B316
		public void SetFaceResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceResultArrayStatus_231(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005638 RID: 22072
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFaceSetArrayStatus_232(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005639 RID: 22073 RVA: 0x0007D127 File Offset: 0x0007B327
		public void SetFaceSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceSetArrayStatus_232(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600563A RID: 22074
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFaceSetResultArrayStatus_233(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600563B RID: 22075 RVA: 0x0007D138 File Offset: 0x0007B338
		public void SetFaceSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFaceSetResultArrayStatus_233(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600563C RID: 22076
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFileId_234(HandleRef pThis, int f);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600563D RID: 22077 RVA: 0x0007D149 File Offset: 0x0007B349
		public virtual void SetFileId(int f)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFileId_234(base.GetCppThis(), f);
		}

		// Token: 0x0600563E RID: 22078
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetFileName_235(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Specify file name of the Exodus file.
		/// </summary>
		// Token: 0x0600563F RID: 22079 RVA: 0x0007D159 File Offset: 0x0007B359
		public virtual void SetFileName(string fname)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetFileName_235(base.GetCppThis(), fname);
		}

		// Token: 0x06005640 RID: 22080
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGenerateFileIdArray_236(HandleRef pThis, int f);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005641 RID: 22081 RVA: 0x0007D169 File Offset: 0x0007B369
		public virtual void SetGenerateFileIdArray(int f)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateFileIdArray_236(base.GetCppThis(), f);
		}

		// Token: 0x06005642 RID: 22082
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGenerateGlobalElementIdArray_237(HandleRef pThis, int g);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005643 RID: 22083 RVA: 0x0007D179 File Offset: 0x0007B379
		public virtual void SetGenerateGlobalElementIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateGlobalElementIdArray_237(base.GetCppThis(), g);
		}

		// Token: 0x06005644 RID: 22084
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGenerateGlobalNodeIdArray_238(HandleRef pThis, int g);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005645 RID: 22085 RVA: 0x0007D189 File Offset: 0x0007B389
		public virtual void SetGenerateGlobalNodeIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateGlobalNodeIdArray_238(base.GetCppThis(), g);
		}

		// Token: 0x06005646 RID: 22086
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGenerateImplicitElementIdArray_239(HandleRef pThis, int g);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005647 RID: 22087 RVA: 0x0007D199 File Offset: 0x0007B399
		public virtual void SetGenerateImplicitElementIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateImplicitElementIdArray_239(base.GetCppThis(), g);
		}

		// Token: 0x06005648 RID: 22088
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGenerateImplicitNodeIdArray_240(HandleRef pThis, int g);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x06005649 RID: 22089 RVA: 0x0007D1A9 File Offset: 0x0007B3A9
		public virtual void SetGenerateImplicitNodeIdArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateImplicitNodeIdArray_240(base.GetCppThis(), g);
		}

		// Token: 0x0600564A RID: 22090
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGenerateObjectIdCellArray_241(HandleRef pThis, int g);

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is ON.  The value of the array is the integer id found
		/// in the exodus file. The name of the array is returned by
		/// GetBlockIdArrayName(). For cells representing elements from
		/// an Exodus element block, this is set to the element block ID. For
		/// cells representing edges from an Exodus edge block, this is the
		/// edge block ID. Similarly, this is the face block ID for cells
		/// representing faces from an Exodus face block. The same holds
		/// for cells representing entries of node, edge, face, side, and element sets.
		/// </summary>
		// Token: 0x0600564B RID: 22091 RVA: 0x0007D1B9 File Offset: 0x0007B3B9
		public virtual void SetGenerateObjectIdCellArray(int g)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGenerateObjectIdCellArray_241(base.GetCppThis(), g);
		}

		// Token: 0x0600564C RID: 22092
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetGlobalResultArrayStatus_242(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600564D RID: 22093 RVA: 0x0007D1C9 File Offset: 0x0007B3C9
		public void SetGlobalResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetGlobalResultArrayStatus_242(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600564E RID: 22094
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetHasModeShapes_243(HandleRef pThis, int ms);

		/// <summary>
		/// Set/Get whether the Exodus sequence number corresponds to time steps or mode shapes.
		/// By default, HasModeShapes is false unless two time values in the Exodus file are identical,
		/// in which case it is true.
		/// </summary>
		// Token: 0x0600564F RID: 22095 RVA: 0x0007D1DA File Offset: 0x0007B3DA
		public virtual void SetHasModeShapes(int ms)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetHasModeShapes_243(base.GetCppThis(), ms);
		}

		// Token: 0x06005650 RID: 22096
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetHierarchyArrayStatus_244(HandleRef pThis, int index, int flag);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x06005651 RID: 22097 RVA: 0x0007D1EA File Offset: 0x0007B3EA
		public void SetHierarchyArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetHierarchyArrayStatus_244(base.GetCppThis(), index, flag);
		}

		// Token: 0x06005652 RID: 22098
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetHierarchyArrayStatus_245(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int flag);

		/// <summary>
		/// By default all hierarchy entries are loaded. These methods allow
		/// the user to
		/// select which hierarchy entries they want to load.  You can get information
		/// about the hierarchy entries by first calling UpdateInformation, and using
		/// GetHierarchyArrayName ...
		/// these methods do not call functions in metaData. They call functions on
		/// the ExodusXMLParser since it seemed silly to duplicate all the information
		/// </summary>
		// Token: 0x06005653 RID: 22099 RVA: 0x0007D1FB File Offset: 0x0007B3FB
		public void SetHierarchyArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetHierarchyArrayStatus_245(base.GetCppThis(), arg0, flag);
		}

		// Token: 0x06005654 RID: 22100
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetIgnoreFileTime_246(HandleRef pThis, byte flag);

		/// <summary>
		/// When on, this option ignores the time values assigned to each time step in
		/// the file. This can be useful for Exodus files where different time steps
		/// are overloaded to represent different aspects of a data set rather than the
		/// data set at different time values.
		/// </summary>
		// Token: 0x06005655 RID: 22101 RVA: 0x0007D20C File Offset: 0x0007B40C
		public virtual void SetIgnoreFileTime(bool flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetIgnoreFileTime_246(base.GetCppThis(), flag ? (byte)1 : (byte)0);
		}

		// Token: 0x06005656 RID: 22102
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetMaterialArrayStatus_247(HandleRef pThis, int index, int flag);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x06005657 RID: 22103 RVA: 0x0007D224 File Offset: 0x0007B424
		public void SetMaterialArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetMaterialArrayStatus_247(base.GetCppThis(), index, flag);
		}

		// Token: 0x06005658 RID: 22104
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetMaterialArrayStatus_248(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int flag);

		/// <summary>
		/// By default all materials are loaded. These methods allow the user to
		/// select which materials they want to load.  You can get information
		/// about the materials by first calling UpdateInformation, and using
		/// GetMaterialArrayName ...
		/// </summary>
		// Token: 0x06005659 RID: 22105 RVA: 0x0007D235 File Offset: 0x0007B435
		public void SetMaterialArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetMaterialArrayStatus_248(base.GetCppThis(), arg0, flag);
		}

		// Token: 0x0600565A RID: 22106
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetModeShape_249(HandleRef pThis, int val);

		/// <summary>
		/// Convenience method to set the mode-shape which is same as
		/// this-&gt;SetTimeStep(val-1);
		/// </summary>
		// Token: 0x0600565B RID: 22107 RVA: 0x0007D246 File Offset: 0x0007B446
		public void SetModeShape(int val)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetModeShape_249(base.GetCppThis(), val);
		}

		// Token: 0x0600565C RID: 22108
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetModeShapeTime_250(HandleRef pThis, double phase);

		/// <summary>
		/// Set/Get the time used to animate mode shapes.
		/// This is a number between 0 and 1 that is used to scale the \a DisplacementMagnitude
		/// in a sinusoidal pattern. Specifically, the displacement vector for each vertex is scaled by
		/// \f$ \mathrm{DisplacementMagnitude} cos( 2\pi \mathrm{ModeShapeTime} ) \f$ before it is
		/// added to the vertex coordinates.
		/// </summary>
		// Token: 0x0600565D RID: 22109 RVA: 0x0007D256 File Offset: 0x0007B456
		public virtual void SetModeShapeTime(double phase)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetModeShapeTime_250(base.GetCppThis(), phase);
		}

		// Token: 0x0600565E RID: 22110
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetNodeMapArrayStatus_251(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x0600565F RID: 22111 RVA: 0x0007D266 File Offset: 0x0007B466
		public void SetNodeMapArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetNodeMapArrayStatus_251(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005660 RID: 22112
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetNodeSetArrayStatus_252(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005661 RID: 22113 RVA: 0x0007D277 File Offset: 0x0007B477
		public void SetNodeSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetNodeSetArrayStatus_252(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005662 RID: 22114
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetNodeSetResultArrayStatus_253(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005663 RID: 22115 RVA: 0x0007D288 File Offset: 0x0007B488
		public void SetNodeSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetNodeSetResultArrayStatus_253(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005664 RID: 22116
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetObjectArrayStatus_254(HandleRef pThis, int objectType, int arrayIndex, int status);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005665 RID: 22117 RVA: 0x0007D299 File Offset: 0x0007B499
		public void SetObjectArrayStatus(int objectType, int arrayIndex, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectArrayStatus_254(base.GetCppThis(), objectType, arrayIndex, status);
		}

		// Token: 0x06005666 RID: 22118
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetObjectArrayStatus_255(HandleRef pThis, int objectType, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int status);

		/// <summary>
		/// By default arrays are not loaded.  These methods allow the user to select
		/// which arrays they want to load.  You can get information about the arrays
		/// by first calling UpdateInformation, and using GetPointArrayName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005667 RID: 22119 RVA: 0x0007D2AB File Offset: 0x0007B4AB
		public void SetObjectArrayStatus(int objectType, string arrayName, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectArrayStatus_255(base.GetCppThis(), objectType, arrayName, status);
		}

		// Token: 0x06005668 RID: 22120
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetObjectAttributeStatus_256(HandleRef pThis, int objectType, int objectIndex, int attribIndex, int status);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x06005669 RID: 22121 RVA: 0x0007D2BD File Offset: 0x0007B4BD
		public void SetObjectAttributeStatus(int objectType, int objectIndex, int attribIndex, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectAttributeStatus_256(base.GetCppThis(), objectType, objectIndex, attribIndex, status);
		}

		// Token: 0x0600566A RID: 22122
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetObjectAttributeStatus_257(HandleRef pThis, int objectType, int objectIndex, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribName, int status);

		/// <summary>
		/// By default attributes are not loaded.  These methods allow the user to select
		/// which attributes they want to load.  You can get information about the attributes
		/// by first calling UpdateInformation, and using GetObjectAttributeName ...
		/// (Developer Note) This meta data is all accessed through vtkExodusMetadata
		/// </summary>
		// Token: 0x0600566B RID: 22123 RVA: 0x0007D2D1 File Offset: 0x0007B4D1
		public void SetObjectAttributeStatus(int objectType, int objectIndex, string attribName, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectAttributeStatus_257(base.GetCppThis(), objectType, objectIndex, attribName, status);
		}

		// Token: 0x0600566C RID: 22124
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetObjectStatus_258(HandleRef pThis, int objectType, int objectIndex, int status);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600566D RID: 22125 RVA: 0x0007D2E5 File Offset: 0x0007B4E5
		public void SetObjectStatus(int objectType, int objectIndex, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectStatus_258(base.GetCppThis(), objectType, objectIndex, status);
		}

		// Token: 0x0600566E RID: 22126
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetObjectStatus_259(HandleRef pThis, int objectType, [MarshalAs(UnmanagedType.LPUTF8Str)] string objectName, int status);

		/// <summary>
		/// Access to meta data generated by UpdateInformation.
		/// </summary>
		// Token: 0x0600566F RID: 22127 RVA: 0x0007D2F7 File Offset: 0x0007B4F7
		public void SetObjectStatus(int objectType, string objectName, int status)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetObjectStatus_259(base.GetCppThis(), objectType, objectName, status);
		}

		// Token: 0x06005670 RID: 22128
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetPartArrayStatus_260(HandleRef pThis, int index, int flag);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x06005671 RID: 22129 RVA: 0x0007D309 File Offset: 0x0007B509
		public void SetPartArrayStatus(int index, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPartArrayStatus_260(base.GetCppThis(), index, flag);
		}

		// Token: 0x06005672 RID: 22130
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetPartArrayStatus_261(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int flag);

		/// <summary>
		/// By default all parts are loaded. These methods allow the user to select
		/// which parts they want to load.  You can get information about the parts
		/// by first calling UpdateInformation, and using GetPartArrayName ...
		/// </summary>
		// Token: 0x06005673 RID: 22131 RVA: 0x0007D31A File Offset: 0x0007B51A
		public void SetPartArrayStatus(string arg0, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPartArrayStatus_261(base.GetCppThis(), arg0, flag);
		}

		// Token: 0x06005674 RID: 22132
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetPointResultArrayStatus_262(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005675 RID: 22133 RVA: 0x0007D32B File Offset: 0x0007B52B
		public void SetPointResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetPointResultArrayStatus_262(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005676 RID: 22134
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetSideSetArrayStatus_263(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005677 RID: 22135 RVA: 0x0007D33C File Offset: 0x0007B53C
		public void SetSideSetArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetSideSetArrayStatus_263(base.GetCppThis(), name, flag);
		}

		// Token: 0x06005678 RID: 22136
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetSideSetResultArrayStatus_264(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int flag);

		/// <summary>
		/// Return the id of the type,name variable
		/// </summary>
		// Token: 0x06005679 RID: 22137 RVA: 0x0007D34D File Offset: 0x0007B54D
		public void SetSideSetResultArrayStatus(string name, int flag)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetSideSetResultArrayStatus_264(base.GetCppThis(), name, flag);
		}

		// Token: 0x0600567A RID: 22138
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetSqueezePoints_265(HandleRef pThis, byte sp);

		/// <summary>
		/// Should the reader output only points used by elements in the output mesh,
		/// or all the points. Outputting all the points is much faster since the
		/// point array can be read straight from disk and the mesh connectivity need
		/// not be altered. Squeezing the points down to the minimum set needed to
		/// produce the output mesh is useful for glyphing and other point-based
		/// operations. On large parallel datasets, loading all the points implies
		/// loading all the points on all processes and performing subsequent
		/// filtering on a much larger set.
		///
		/// By default, SqueezePoints is true for backwards compatibility.
		/// </summary>
		// Token: 0x0600567B RID: 22139 RVA: 0x0007D35E File Offset: 0x0007B55E
		public void SetSqueezePoints(bool sp)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetSqueezePoints_265(base.GetCppThis(), sp ? (byte)1 : (byte)0);
		}

		// Token: 0x0600567C RID: 22140
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetTimeStep_266(HandleRef pThis, int _arg);

		/// <summary>
		/// Which TimeStep to read.
		/// </summary>
		// Token: 0x0600567D RID: 22141 RVA: 0x0007D376 File Offset: 0x0007B576
		public virtual void SetTimeStep(int _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetTimeStep_266(base.GetCppThis(), _arg);
		}

		// Token: 0x0600567E RID: 22142
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetUseLegacyBlockNames_267(HandleRef pThis, byte _arg);

		/// <summary>
		/// In previous versions, the reader added the type of elements in the block to
		/// the block name when no name was provided for the block. This has issues
		/// with consistency when naming blocks across ranks for partitioned files
		/// (see paraview/paraview#19110), hence we no longer do that. For legacy
		/// pipelines, one can enable the old behavior by setting this flag to true.
		/// </summary>
		// Token: 0x0600567F RID: 22143 RVA: 0x0007D386 File Offset: 0x0007B586
		public virtual void SetUseLegacyBlockNames(bool _arg)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetUseLegacyBlockNames_267(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005680 RID: 22144
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_SetXMLFileName_268(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Specify file name of the xml file.
		/// </summary>
		// Token: 0x06005681 RID: 22145 RVA: 0x0007D39E File Offset: 0x0007B59E
		public virtual void SetXMLFileName(string fname)
		{
			vtkExodusIIReader.vtkExodusIIReader_SetXMLFileName_268(base.GetCppThis(), fname);
		}

		// Token: 0x06005682 RID: 22146
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_UseLegacyBlockNamesOff_269(HandleRef pThis);

		/// <summary>
		/// In previous versions, the reader added the type of elements in the block to
		/// the block name when no name was provided for the block. This has issues
		/// with consistency when naming blocks across ranks for partitioned files
		/// (see paraview/paraview#19110), hence we no longer do that. For legacy
		/// pipelines, one can enable the old behavior by setting this flag to true.
		/// </summary>
		// Token: 0x06005683 RID: 22147 RVA: 0x0007D3AE File Offset: 0x0007B5AE
		public virtual void UseLegacyBlockNamesOff()
		{
			vtkExodusIIReader.vtkExodusIIReader_UseLegacyBlockNamesOff_269(base.GetCppThis());
		}

		// Token: 0x06005684 RID: 22148
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReader_UseLegacyBlockNamesOn_270(HandleRef pThis);

		/// <summary>
		/// In previous versions, the reader added the type of elements in the block to
		/// the block name when no name was provided for the block. This has issues
		/// with consistency when naming blocks across ranks for partitioned files
		/// (see paraview/paraview#19110), hence we no longer do that. For legacy
		/// pipelines, one can enable the old behavior by setting this flag to true.
		/// </summary>
		// Token: 0x06005685 RID: 22149 RVA: 0x0007D3BD File Offset: 0x0007B5BD
		public virtual void UseLegacyBlockNamesOn()
		{
			vtkExodusIIReader.vtkExodusIIReader_UseLegacyBlockNamesOn_270(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007DD RID: 2013
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007DE RID: 2014
		public new static readonly string MRClassNameKey = "class vtkExodusIIReader";

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x020001B9 RID: 441
		public enum ID_NOT_FOUND_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040007E0 RID: 2016
			ID_NOT_FOUND = -234121312,
			/// <summary>enum member</summary>
			// Token: 0x040007E1 RID: 2017
			SEARCH_TYPE_ELEMENT = 0,
			/// <summary>enum member</summary>
			// Token: 0x040007E2 RID: 2018
			SEARCH_TYPE_ELEMENT_THEN_NODE = 2,
			/// <summary>enum member</summary>
			// Token: 0x040007E3 RID: 2019
			SEARCH_TYPE_NODE = 1,
			/// <summary>enum member</summary>
			// Token: 0x040007E4 RID: 2020
			SEARCH_TYPE_NODE_THEN_ELEMENT = 3
		}

		/// <summary>
		/// Extra cell data array that can be generated.  By default, this array
		/// is off.  The value of the array is the integer global id of the cell.
		/// The name of the array is returned by GetGlobalElementIdArrayName()
		/// ***NOTE*** No more "unique" global ID. Instead we have an arbitrary number of maps.
		/// </summary>
		// Token: 0x020001BA RID: 442
		public enum ObjectType
		{
			/// <summary>enum member</summary>
			// Token: 0x040007E6 RID: 2022
			ASSEMBLY = 60,
			/// <summary>enum member</summary>
			// Token: 0x040007E7 RID: 2023
			EDGE_BLOCK = 6,
			/// <summary>enum member</summary>
			// Token: 0x040007E8 RID: 2024
			EDGE_BLOCK_ATTRIB = 79,
			/// <summary>enum member</summary>
			// Token: 0x040007E9 RID: 2025
			EDGE_BLOCK_CONN = 94,
			/// <summary>enum member</summary>
			// Token: 0x040007EA RID: 2026
			EDGE_ID = 106,
			/// <summary>enum member</summary>
			// Token: 0x040007EB RID: 2027
			EDGE_MAP = 11,
			/// <summary>enum member</summary>
			// Token: 0x040007EC RID: 2028
			EDGE_SET = 7,
			/// <summary>enum member</summary>
			// Token: 0x040007ED RID: 2029
			EDGE_SET_CONN = 90,
			/// <summary>enum member</summary>
			// Token: 0x040007EE RID: 2030
			ELEMENT_ID = 84,
			/// <summary>enum member</summary>
			// Token: 0x040007EF RID: 2031
			ELEM_BLOCK = 1,
			/// <summary>enum member</summary>
			// Token: 0x040007F0 RID: 2032
			ELEM_BLOCK_ATTRIB = 81,
			/// <summary>enum member</summary>
			// Token: 0x040007F1 RID: 2033
			ELEM_BLOCK_EDGE_CONN = 96,
			/// <summary>enum member</summary>
			// Token: 0x040007F2 RID: 2034
			ELEM_BLOCK_ELEM_CONN = 98,
			/// <summary>enum member</summary>
			// Token: 0x040007F3 RID: 2035
			ELEM_BLOCK_FACE_CONN = 97,
			/// <summary>enum member</summary>
			// Token: 0x040007F4 RID: 2036
			ELEM_BLOCK_TEMPORAL = 100,
			/// <summary>enum member</summary>
			// Token: 0x040007F5 RID: 2037
			ELEM_MAP = 4,
			/// <summary>enum member</summary>
			// Token: 0x040007F6 RID: 2038
			ELEM_SET = 10,
			/// <summary>enum member</summary>
			// Token: 0x040007F7 RID: 2039
			ELEM_SET_CONN = 93,
			/// <summary>enum member</summary>
			// Token: 0x040007F8 RID: 2040
			ENTITY_COUNTS = 109,
			/// <summary>enum member</summary>
			// Token: 0x040007F9 RID: 2041
			FACE_BLOCK = 8,
			/// <summary>enum member</summary>
			// Token: 0x040007FA RID: 2042
			FACE_BLOCK_ATTRIB = 80,
			/// <summary>enum member</summary>
			// Token: 0x040007FB RID: 2043
			FACE_BLOCK_CONN = 95,
			/// <summary>enum member</summary>
			// Token: 0x040007FC RID: 2044
			FACE_ID = 105,
			/// <summary>enum member</summary>
			// Token: 0x040007FD RID: 2045
			FACE_MAP = 12,
			/// <summary>enum member</summary>
			// Token: 0x040007FE RID: 2046
			FACE_SET = 9,
			/// <summary>enum member</summary>
			// Token: 0x040007FF RID: 2047
			FACE_SET_CONN = 91,
			/// <summary>enum member</summary>
			// Token: 0x04000800 RID: 2048
			GLOBAL = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000801 RID: 2049
			GLOBAL_CONN = 99,
			/// <summary>enum member</summary>
			// Token: 0x04000802 RID: 2050
			GLOBAL_ELEMENT_ID = 86,
			/// <summary>enum member</summary>
			// Token: 0x04000803 RID: 2051
			GLOBAL_NODE_ID = 85,
			/// <summary>enum member</summary>
			// Token: 0x04000804 RID: 2052
			GLOBAL_TEMPORAL = 102,
			/// <summary>enum member</summary>
			// Token: 0x04000805 RID: 2053
			HIERARCHY = 63,
			/// <summary>enum member</summary>
			// Token: 0x04000806 RID: 2054
			IMPLICIT_ELEMENT_ID = 108,
			/// <summary>enum member</summary>
			// Token: 0x04000807 RID: 2055
			IMPLICIT_NODE_ID = 107,
			/// <summary>enum member</summary>
			// Token: 0x04000808 RID: 2056
			INFO_RECORDS = 104,
			/// <summary>enum member</summary>
			// Token: 0x04000809 RID: 2057
			MATERIAL = 62,
			/// <summary>enum member</summary>
			// Token: 0x0400080A RID: 2058
			NODAL = 14,
			/// <summary>enum member</summary>
			// Token: 0x0400080B RID: 2059
			NODAL_COORDS = 88,
			/// <summary>enum member</summary>
			// Token: 0x0400080C RID: 2060
			NODAL_SQUEEZEMAP = 82,
			/// <summary>enum member</summary>
			// Token: 0x0400080D RID: 2061
			NODAL_TEMPORAL = 101,
			/// <summary>enum member</summary>
			// Token: 0x0400080E RID: 2062
			NODE_ID = 83,
			/// <summary>enum member</summary>
			// Token: 0x0400080F RID: 2063
			NODE_MAP = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000810 RID: 2064
			NODE_SET = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000811 RID: 2065
			NODE_SET_CONN = 89,
			/// <summary>enum member</summary>
			// Token: 0x04000812 RID: 2066
			OBJECT_ID = 87,
			/// <summary>enum member</summary>
			// Token: 0x04000813 RID: 2067
			PART = 61,
			/// <summary>enum member</summary>
			// Token: 0x04000814 RID: 2068
			QA_RECORDS = 103,
			/// <summary>enum member</summary>
			// Token: 0x04000815 RID: 2069
			SIDE_SET = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000816 RID: 2070
			SIDE_SET_CONN = 92
		}
	}
}
