using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkIOSSWriter
	/// </summary>
	/// <remarks>
	///  Writer for IOSS (Sierra IO System)
	///
	/// vtkIOSSWriter is a writer that uses the IOSS (Sierra IO System) library to write files.
	/// Currently this writer supports the Exodus file format. IOSS imposes certain restrictions
	/// on the aforementioned file format and hence it may not be possible to write every dataset
	/// as an Exodus file using this writer. This is rare for the Exodus.
	///
	/// This writer generates files using the same naming conventions that vtkIOSSReader understands.
	///
	/// @section SelectingBlocksSetsToWrite Selecting blocks and sets to write
	///
	/// An IOSS file comprises of blocks and sets of various types. These are
	/// described by the enum `vtkIOSSReader::EntityType`. If the input of the writer
	/// was initially read by the vtkIOSSReader, then the entity types can be automatically
	/// deduced. If it was not initially read by vtkIOSSReader (or even if it was), the assembly
	/// name and selectors can be utilized to define which blocks are e.g. element blocks, or side sets.
	/// `vtkIOSSWriter::SetAssemblyName(...)` can be used to set the assembly, and
	/// `vtkIOSSWriter::AddSelector(...)` (or one of its convenience variants) can be used to add
	/// selectors. If no selectors have been defined all partitions will be treated as element blocks.
	///
	/// Typical usage is as follows:
	///
	/// @code{.cpp}
	/// vtkNew&lt;vtkIOSSWriter&gt; writer;
	/// writer-&gt;SetInputData(...)
	/// writer-&gt;SetFileName(...);
	/// writer-&gt;SetAssemblyName("Assembly");
	/// writer-&gt;AddElementBlockSelector("/IOSS/element_blocks");
	/// writer-&gt;Write();
	/// @endcode
	///
	/// @section SelectingArraysToWrite Selecting arrays to write
	///
	/// Similar arrays (or fields as IOSS refers to them) to read from each of the blocks or sets
	/// can be specified using the `vtkDataArraySelection` instance returned using
	/// `vtkIOSSWriter::GetFieldSelection` (or one of its convenience variants).
	///
	/// By default all arrays are enabled. To write specific arrays, f
	/// ChooseFieldsToWrite has to be true, which can change using
	/// `vtkIOSSWriter::SetChooseFieldsToWrite(true)`.
	///
	/// Typical usage is as follows:
	///
	/// @code{.cpp}
	/// vtkNew&lt;vtkIOSSWriter&gt; writer;
	/// writer-&gt;SetInputData(...)
	/// writer-&gt;SetFileName(...);
	/// writer-&gt;SetAssemblyName("Assembly");
	/// writer-&gt;AddElementBlockSelector("/IOSS/element_blocks");
	/// writer-&gt;SetChooseFieldsToWrite(true);
	/// writer-&gt;GetElementBlockFieldSelection()-&gt;EnableArray("EQPS");
	/// writer-&gt;Write();
	/// @endcode
	///
	/// @section SelectionTimeSteps Selection TimeSteps
	///
	/// `vtkIOSSWriter::SetTimeStepRange(...)` and `vtkIOSSWriter::SetTimeStepStride(...)`
	/// can be used to write a subset of time steps using a range and a stride.
	///
	/// @section UpcomingFeatures Upcoming features
	///
	/// The following features are planned to be implemented in the future:
	/// \li Support CGNS file format.
	/// \li Support writing global data
	/// \li Support writing pedigree IDs
	///
	/// @section Appendix Appendix
	/// * [Sierra IO System](https://sandialabs.github.io/seacas-docs)
	/// * [Exodus file format](https://sandialabs.github.io/seacas-docs/ExodusII-Addendum.pdf)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkIOSSReader, vtkExodusIIWriter
	/// </seealso>
	// Token: 0x0200018B RID: 395
	public class vtkIOSSWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004C63 RID: 19555 RVA: 0x0006F708 File Offset: 0x0006D908
		static vtkIOSSWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIOSSWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIOSSWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004C64 RID: 19556 RVA: 0x0006F730 File Offset: 0x0006D930
		public vtkIOSSWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004C65 RID: 19557
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004C66 RID: 19558 RVA: 0x0006F740 File Offset: 0x0006D940
		public new static vtkIOSSWriter New()
		{
			vtkIOSSWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIOSSWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004C67 RID: 19559 RVA: 0x0006F794 File Offset: 0x0006D994
		public vtkIOSSWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIOSSWriter.vtkIOSSWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004C68 RID: 19560 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004C69 RID: 19561
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddEdgeBlockSelector_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get edge block selectors
		/// </summary>
		// Token: 0x06004C6A RID: 19562 RVA: 0x0006F7E4 File Offset: 0x0006D9E4
		public bool AddEdgeBlockSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddEdgeBlockSelector_01(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C6B RID: 19563
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddEdgeSetSelector_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004C6C RID: 19564 RVA: 0x0006F80C File Offset: 0x0006DA0C
		public bool AddEdgeSetSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddEdgeSetSelector_02(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C6D RID: 19565
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddElementBlockSelector_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get element block selectors
		/// </summary>
		// Token: 0x06004C6E RID: 19566 RVA: 0x0006F834 File Offset: 0x0006DA34
		public bool AddElementBlockSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddElementBlockSelector_03(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C6F RID: 19567
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddElementSetSelector_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get element set selectors
		/// </summary>
		// Token: 0x06004C70 RID: 19568 RVA: 0x0006F85C File Offset: 0x0006DA5C
		public bool AddElementSetSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddElementSetSelector_04(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C71 RID: 19569
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddFaceBlockSelector_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get face block selectors
		/// </summary>
		// Token: 0x06004C72 RID: 19570 RVA: 0x0006F884 File Offset: 0x0006DA84
		public bool AddFaceBlockSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddFaceBlockSelector_05(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C73 RID: 19571
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddFaceSetSelector_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004C74 RID: 19572 RVA: 0x0006F8AC File Offset: 0x0006DAAC
		public bool AddFaceSetSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddFaceSetSelector_06(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C75 RID: 19573
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddNodeSetSelector_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get node set selectors
		/// </summary>
		// Token: 0x06004C76 RID: 19574 RVA: 0x0006F8D4 File Offset: 0x0006DAD4
		public bool AddNodeSetSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddNodeSetSelector_07(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C77 RID: 19575
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddSelector_08(HandleRef pThis, vtkIOSSReader.EntityType entity, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// API to set entity selectors. Multiple selectors can be added using
		/// `AddSelector`. The order in which selectors are specified is not preserved
		/// and has no impact on the result.
		///
		/// `AddSelector` returns true if the selector was added, false if the selector
		/// was already specified and hence not added.
		///
		/// @sa vtkDataAssembly::SelectNodes
		/// </summary>
		// Token: 0x06004C78 RID: 19576 RVA: 0x0006F8FC File Offset: 0x0006DAFC
		public bool AddSelector(vtkIOSSReader.EntityType entity, string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddSelector_08(base.GetCppThis(), entity, selector) != 0;
		}

		// Token: 0x06004C79 RID: 19577
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_AddSideSetSelector_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get side set selectors
		/// </summary>
		// Token: 0x06004C7A RID: 19578 RVA: 0x0006F924 File Offset: 0x0006DB24
		public bool AddSideSetSelector(string selector)
		{
			return vtkIOSSWriter.vtkIOSSWriter_AddSideSetSelector_09(base.GetCppThis(), selector) != 0;
		}

		// Token: 0x06004C7B RID: 19579
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ChooseFieldsToWriteOff_10(HandleRef pThis);

		/// <summary>
		/// Choose which fields to write. If this is true, then only the
		/// arrays selected will be written. If this is false, then all arrays will be
		/// written.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004C7C RID: 19580 RVA: 0x0006F94B File Offset: 0x0006DB4B
		public virtual void ChooseFieldsToWriteOff()
		{
			vtkIOSSWriter.vtkIOSSWriter_ChooseFieldsToWriteOff_10(base.GetCppThis());
		}

		// Token: 0x06004C7D RID: 19581
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ChooseFieldsToWriteOn_11(HandleRef pThis);

		/// <summary>
		/// Choose which fields to write. If this is true, then only the
		/// arrays selected will be written. If this is false, then all arrays will be
		/// written.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004C7E RID: 19582 RVA: 0x0006F95A File Offset: 0x0006DB5A
		public virtual void ChooseFieldsToWriteOn()
		{
			vtkIOSSWriter.vtkIOSSWriter_ChooseFieldsToWriteOn_11(base.GetCppThis());
		}

		// Token: 0x06004C7F RID: 19583
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearEdgeBlockSelectors_12(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get edge block selectors
		/// </summary>
		// Token: 0x06004C80 RID: 19584 RVA: 0x0006F969 File Offset: 0x0006DB69
		public void ClearEdgeBlockSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearEdgeBlockSelectors_12(base.GetCppThis());
		}

		// Token: 0x06004C81 RID: 19585
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearEdgeSetSelectors_13(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004C82 RID: 19586 RVA: 0x0006F978 File Offset: 0x0006DB78
		public void ClearEdgeSetSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearEdgeSetSelectors_13(base.GetCppThis());
		}

		// Token: 0x06004C83 RID: 19587
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearElementBlockSelectors_14(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get element block selectors
		/// </summary>
		// Token: 0x06004C84 RID: 19588 RVA: 0x0006F987 File Offset: 0x0006DB87
		public void ClearElementBlockSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearElementBlockSelectors_14(base.GetCppThis());
		}

		// Token: 0x06004C85 RID: 19589
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearElementSetSelectors_15(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get element set selectors
		/// </summary>
		// Token: 0x06004C86 RID: 19590 RVA: 0x0006F996 File Offset: 0x0006DB96
		public void ClearElementSetSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearElementSetSelectors_15(base.GetCppThis());
		}

		// Token: 0x06004C87 RID: 19591
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearFaceBlockSelectors_16(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get face block selectors
		/// </summary>
		// Token: 0x06004C88 RID: 19592 RVA: 0x0006F9A5 File Offset: 0x0006DBA5
		public void ClearFaceBlockSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearFaceBlockSelectors_16(base.GetCppThis());
		}

		// Token: 0x06004C89 RID: 19593
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearFaceSetSelectors_17(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004C8A RID: 19594 RVA: 0x0006F9B4 File Offset: 0x0006DBB4
		public void ClearFaceSetSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearFaceSetSelectors_17(base.GetCppThis());
		}

		// Token: 0x06004C8B RID: 19595
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearNodeSetSelectors_18(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get node set selectors
		/// </summary>
		// Token: 0x06004C8C RID: 19596 RVA: 0x0006F9C3 File Offset: 0x0006DBC3
		public void ClearNodeSetSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearNodeSetSelectors_18(base.GetCppThis());
		}

		// Token: 0x06004C8D RID: 19597
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearSelectors_19(HandleRef pThis, vtkIOSSReader.EntityType entity);

		/// <summary>
		/// API to set entity selectors. Multiple selectors can be added using
		/// `AddSelector`. The order in which selectors are specified is not preserved
		/// and has no impact on the result.
		///
		/// `AddSelector` returns true if the selector was added, false if the selector
		/// was already specified and hence not added.
		///
		/// @sa vtkDataAssembly::SelectNodes
		/// </summary>
		// Token: 0x06004C8E RID: 19598 RVA: 0x0006F9D2 File Offset: 0x0006DBD2
		public void ClearSelectors(vtkIOSSReader.EntityType entity)
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearSelectors_19(base.GetCppThis(), entity);
		}

		// Token: 0x06004C8F RID: 19599
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_ClearSideSetSelectors_20(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get side set selectors
		/// </summary>
		// Token: 0x06004C90 RID: 19600 RVA: 0x0006F9E2 File Offset: 0x0006DBE2
		public void ClearSideSetSelectors()
		{
			vtkIOSSWriter.vtkIOSSWriter_ClearSideSetSelectors_20(base.GetCppThis());
		}

		// Token: 0x06004C91 RID: 19601
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetAssemblyName_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the active assembly to use. The chosen assembly is used
		/// in combination with the selectors specified to determine which blocks
		/// are to be extracted.
		///
		/// The default is set to vtkDataAssemblyUtilities::HierarchyName().
		/// </summary>
		// Token: 0x06004C92 RID: 19602 RVA: 0x0006F9F4 File Offset: 0x0006DBF4
		public virtual string GetAssemblyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetAssemblyName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004C93 RID: 19603
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_GetChooseFieldsToWrite_22(HandleRef pThis);

		/// <summary>
		/// Choose which fields to write. If this is true, then only the
		/// arrays selected will be written. If this is false, then all arrays will be
		/// written.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004C94 RID: 19604 RVA: 0x0006FA30 File Offset: 0x0006DC30
		public virtual bool GetChooseFieldsToWrite()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetChooseFieldsToWrite_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06004C95 RID: 19605
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetController_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use when working in parallel. Initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		///
		/// The controller is used to determine the upstream piece request in
		/// RequestUpdateExtent.
		/// </summary>
		// Token: 0x06004C96 RID: 19606 RVA: 0x0006FA58 File Offset: 0x0006DC58
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetController_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004C97 RID: 19607
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIOSSWriter_GetDisplacementMagnitude_24(HandleRef pThis);

		/// <summary>
		/// If input dataset has displacements pre-applied, setting the displacement
		/// magnitude to non-zero ensures that the point coordinates in the dataset are
		/// correctly transformed using the displacement field array, if present.
		///
		/// Defaults to 1.0.
		/// </summary>
		// Token: 0x06004C98 RID: 19608 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
		public virtual double GetDisplacementMagnitude()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetDisplacementMagnitude_24(base.GetCppThis());
		}

		// Token: 0x06004C99 RID: 19609
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIOSSWriter_GetDisplacementMagnitudeMaxValue_25(HandleRef pThis);

		/// <summary>
		/// If input dataset has displacements pre-applied, setting the displacement
		/// magnitude to non-zero ensures that the point coordinates in the dataset are
		/// correctly transformed using the displacement field array, if present.
		///
		/// Defaults to 1.0.
		/// </summary>
		// Token: 0x06004C9A RID: 19610 RVA: 0x0006FAE8 File Offset: 0x0006DCE8
		public virtual double GetDisplacementMagnitudeMaxValue()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetDisplacementMagnitudeMaxValue_25(base.GetCppThis());
		}

		// Token: 0x06004C9B RID: 19611
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIOSSWriter_GetDisplacementMagnitudeMinValue_26(HandleRef pThis);

		/// <summary>
		/// If input dataset has displacements pre-applied, setting the displacement
		/// magnitude to non-zero ensures that the point coordinates in the dataset are
		/// correctly transformed using the displacement field array, if present.
		///
		/// Defaults to 1.0.
		/// </summary>
		// Token: 0x06004C9C RID: 19612 RVA: 0x0006FB08 File Offset: 0x0006DD08
		public virtual double GetDisplacementMagnitudeMinValue()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetDisplacementMagnitudeMinValue_26(base.GetCppThis());
		}

		// Token: 0x06004C9D RID: 19613
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetEdgeBlockFieldSelection_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the edge block arrays.
		/// </summary>
		// Token: 0x06004C9E RID: 19614 RVA: 0x0006FB28 File Offset: 0x0006DD28
		public vtkDataArraySelection GetEdgeBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetEdgeBlockFieldSelection_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004C9F RID: 19615
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetEdgeBlockSelector_28(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get edge block selectors
		/// </summary>
		// Token: 0x06004CA0 RID: 19616 RVA: 0x0006FB98 File Offset: 0x0006DD98
		public string GetEdgeBlockSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetEdgeBlockSelector_28(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CA1 RID: 19617
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetEdgeSetFieldSelection_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the edge set arrays.
		/// </summary>
		// Token: 0x06004CA2 RID: 19618 RVA: 0x0006FBD4 File Offset: 0x0006DDD4
		public vtkDataArraySelection GetEdgeSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetEdgeSetFieldSelection_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CA3 RID: 19619
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetEdgeSetSelector_30(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004CA4 RID: 19620 RVA: 0x0006FC44 File Offset: 0x0006DE44
		public string GetEdgeSetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetEdgeSetSelector_30(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CA5 RID: 19621
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetElementBlockFieldSelection_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the element block arrays.
		/// </summary>
		// Token: 0x06004CA6 RID: 19622 RVA: 0x0006FC80 File Offset: 0x0006DE80
		public vtkDataArraySelection GetElementBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetElementBlockFieldSelection_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CA7 RID: 19623
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetElementBlockSelector_32(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get element block selectors
		/// </summary>
		// Token: 0x06004CA8 RID: 19624 RVA: 0x0006FCF0 File Offset: 0x0006DEF0
		public string GetElementBlockSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetElementBlockSelector_32(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CA9 RID: 19625
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetElementSetFieldSelection_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the element set arrays.
		/// </summary>
		// Token: 0x06004CAA RID: 19626 RVA: 0x0006FD2C File Offset: 0x0006DF2C
		public vtkDataArraySelection GetElementSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetElementSetFieldSelection_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CAB RID: 19627
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetElementSetSelector_34(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get element set selectors
		/// </summary>
		// Token: 0x06004CAC RID: 19628 RVA: 0x0006FD9C File Offset: 0x0006DF9C
		public string GetElementSetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetElementSetSelector_34(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CAD RID: 19629
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetFaceBlockFieldSelection_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the face block arrays.
		/// </summary>
		// Token: 0x06004CAE RID: 19630 RVA: 0x0006FDD8 File Offset: 0x0006DFD8
		public vtkDataArraySelection GetFaceBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetFaceBlockFieldSelection_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CAF RID: 19631
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetFaceBlockSelector_36(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get face block selectors
		/// </summary>
		// Token: 0x06004CB0 RID: 19632 RVA: 0x0006FE48 File Offset: 0x0006E048
		public string GetFaceBlockSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetFaceBlockSelector_36(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CB1 RID: 19633
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetFaceSetFieldSelection_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the edge set arrays.
		/// </summary>
		// Token: 0x06004CB2 RID: 19634 RVA: 0x0006FE84 File Offset: 0x0006E084
		public vtkDataArraySelection GetFaceSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetFaceSetFieldSelection_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CB3 RID: 19635
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetFaceSetSelector_38(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004CB4 RID: 19636 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
		public string GetFaceSetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetFaceSetSelector_38(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CB5 RID: 19637
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetFieldSelection_39(HandleRef pThis, vtkIOSSReader.EntityType type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the selection object for the given entity type. This can be used to
		/// select which fields to write.
		/// </summary>
		// Token: 0x06004CB6 RID: 19638 RVA: 0x0006FF30 File Offset: 0x0006E130
		public vtkDataArraySelection GetFieldSelection(vtkIOSSReader.EntityType type)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetFieldSelection_39(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CB7 RID: 19639
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetFileName_40(HandleRef pThis);

		/// <summary>
		/// Get/set the filename. When writing in a distributed environment, the
		/// actual filename written out may be different.
		/// </summary>
		// Token: 0x06004CB8 RID: 19640 RVA: 0x0006FFA0 File Offset: 0x0006E1A0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetFileName_40(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CB9 RID: 19641
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetNodeBlockFieldSelection_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the element block arrays.
		/// </summary>
		// Token: 0x06004CBA RID: 19642 RVA: 0x0006FFDC File Offset: 0x0006E1DC
		public vtkDataArraySelection GetNodeBlockFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetNodeBlockFieldSelection_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CBB RID: 19643
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetNodeSetFieldSelection_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the node set arrays.
		/// </summary>
		// Token: 0x06004CBC RID: 19644 RVA: 0x0007004C File Offset: 0x0006E24C
		public vtkDataArraySelection GetNodeSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetNodeSetFieldSelection_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CBD RID: 19645
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetNodeSetSelector_43(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get node set selectors
		/// </summary>
		// Token: 0x06004CBE RID: 19646 RVA: 0x000700BC File Offset: 0x0006E2BC
		public string GetNodeSetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetNodeSetSelector_43(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CBF RID: 19647
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfEdgeBlockSelectors_44(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get edge block selectors
		/// </summary>
		// Token: 0x06004CC0 RID: 19648 RVA: 0x000700F8 File Offset: 0x0006E2F8
		public int GetNumberOfEdgeBlockSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfEdgeBlockSelectors_44(base.GetCppThis());
		}

		// Token: 0x06004CC1 RID: 19649
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfEdgeSetSelectors_45(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004CC2 RID: 19650 RVA: 0x00070118 File Offset: 0x0006E318
		public int GetNumberOfEdgeSetSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfEdgeSetSelectors_45(base.GetCppThis());
		}

		// Token: 0x06004CC3 RID: 19651
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfElementBlockSelectors_46(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get element block selectors
		/// </summary>
		// Token: 0x06004CC4 RID: 19652 RVA: 0x00070138 File Offset: 0x0006E338
		public int GetNumberOfElementBlockSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfElementBlockSelectors_46(base.GetCppThis());
		}

		// Token: 0x06004CC5 RID: 19653
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfElementSetSelectors_47(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get element set selectors
		/// </summary>
		// Token: 0x06004CC6 RID: 19654 RVA: 0x00070158 File Offset: 0x0006E358
		public int GetNumberOfElementSetSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfElementSetSelectors_47(base.GetCppThis());
		}

		// Token: 0x06004CC7 RID: 19655
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfFaceBlockSelectors_48(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get face block selectors
		/// </summary>
		// Token: 0x06004CC8 RID: 19656 RVA: 0x00070178 File Offset: 0x0006E378
		public int GetNumberOfFaceBlockSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfFaceBlockSelectors_48(base.GetCppThis());
		}

		// Token: 0x06004CC9 RID: 19657
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfFaceSetSelectors_49(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004CCA RID: 19658 RVA: 0x00070198 File Offset: 0x0006E398
		public int GetNumberOfFaceSetSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfFaceSetSelectors_49(base.GetCppThis());
		}

		// Token: 0x06004CCB RID: 19659
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIOSSWriter_GetNumberOfGenerationsFromBase_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004CCC RID: 19660 RVA: 0x000701B8 File Offset: 0x0006E3B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfGenerationsFromBase_50(base.GetCppThis(), type);
		}

		// Token: 0x06004CCD RID: 19661
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIOSSWriter_GetNumberOfGenerationsFromBaseType_51([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004CCE RID: 19662 RVA: 0x000701D8 File Offset: 0x0006E3D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfGenerationsFromBaseType_51(type);
		}

		// Token: 0x06004CCF RID: 19663
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfNodeSetSelectors_52(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get node set selectors
		/// </summary>
		// Token: 0x06004CD0 RID: 19664 RVA: 0x000701F4 File Offset: 0x0006E3F4
		public int GetNumberOfNodeSetSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfNodeSetSelectors_52(base.GetCppThis());
		}

		// Token: 0x06004CD1 RID: 19665
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfSelectors_53(HandleRef pThis, vtkIOSSReader.EntityType entity);

		/// <summary>
		/// API to access entity selectors.
		/// </summary>
		// Token: 0x06004CD2 RID: 19666 RVA: 0x00070214 File Offset: 0x0006E414
		public int GetNumberOfSelectors(vtkIOSSReader.EntityType entity)
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfSelectors_53(base.GetCppThis(), entity);
		}

		// Token: 0x06004CD3 RID: 19667
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetNumberOfSideSetSelectors_54(HandleRef pThis);

		/// <summary>
		/// Add/Clear/Set/Get side set selectors
		/// </summary>
		// Token: 0x06004CD4 RID: 19668 RVA: 0x00070234 File Offset: 0x0006E434
		public int GetNumberOfSideSetSelectors()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetNumberOfSideSetSelectors_54(base.GetCppThis());
		}

		// Token: 0x06004CD5 RID: 19669
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_GetOffsetGlobalIds_55(HandleRef pThis);

		/// <summary>
		/// Exodus wants global ids to start with 1, while VTK generally produces
		/// global ids starting with 0. Set this to true (default false), if the global
		/// ids are generated by VTK and hence start with 0. When writing to the output
		/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
		/// </summary>
		// Token: 0x06004CD6 RID: 19670 RVA: 0x00070254 File Offset: 0x0006E454
		public virtual bool GetOffsetGlobalIds()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetOffsetGlobalIds_55(base.GetCppThis()) != 0;
		}

		// Token: 0x06004CD7 RID: 19671
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_GetPreserveOriginalIds_56(HandleRef pThis);

		/// <summary>
		/// If input is transformed, e.g. through clipping, new element blocks may be created.
		/// This flag can be used to indicate whether to preserve the original ids from blocks.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004CD8 RID: 19672 RVA: 0x0007027C File Offset: 0x0006E47C
		public virtual bool GetPreserveOriginalIds()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetPreserveOriginalIds_56(base.GetCppThis()) != 0;
		}

		// Token: 0x06004CD9 RID: 19673
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_GetRemoveGhosts_57(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to write remove ghost cells from the input.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x06004CDA RID: 19674 RVA: 0x000702A4 File Offset: 0x0006E4A4
		public virtual bool GetRemoveGhosts()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetRemoveGhosts_57(base.GetCppThis()) != 0;
		}

		// Token: 0x06004CDB RID: 19675
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetSelector_58(HandleRef pThis, vtkIOSSReader.EntityType entity, int index);

		/// <summary>
		/// API to access entity selectors.
		/// </summary>
		// Token: 0x06004CDC RID: 19676 RVA: 0x000702CC File Offset: 0x0006E4CC
		public string GetSelector(vtkIOSSReader.EntityType entity, int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetSelector_58(base.GetCppThis(), entity, index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CDD RID: 19677
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetSideSetFieldSelection_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the field selection object for the side set arrays.
		/// </summary>
		// Token: 0x06004CDE RID: 19678 RVA: 0x00070308 File Offset: 0x0006E508
		public vtkDataArraySelection GetSideSetFieldSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetSideSetFieldSelection_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004CDF RID: 19679
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetSideSetSelector_60(HandleRef pThis, int index);

		/// <summary>
		/// Add/Clear/Set/Get side set selectors
		/// </summary>
		// Token: 0x06004CE0 RID: 19680 RVA: 0x00070378 File Offset: 0x0006E578
		public string GetSideSetSelector(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkIOSSWriter.vtkIOSSWriter_GetSideSetSelector_60(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004CE1 RID: 19681
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_GetTimeStepRange_61(HandleRef pThis);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004CE2 RID: 19682 RVA: 0x000703B4 File Offset: 0x0006E5B4
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_GetTimeStepRange_61(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004CE3 RID: 19683
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_GetTimeStepRange_62(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004CE4 RID: 19684 RVA: 0x000703FC File Offset: 0x0006E5FC
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkIOSSWriter.vtkIOSSWriter_GetTimeStepRange_62(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06004CE5 RID: 19685
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_GetTimeStepRange_63(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004CE6 RID: 19686 RVA: 0x0007040D File Offset: 0x0006E60D
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_GetTimeStepRange_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06004CE7 RID: 19687
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetTimeStepStride_64(HandleRef pThis);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004CE8 RID: 19688 RVA: 0x00070420 File Offset: 0x0006E620
		public virtual int GetTimeStepStride()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetTimeStepStride_64(base.GetCppThis());
		}

		// Token: 0x06004CE9 RID: 19689
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetTimeStepStrideMaxValue_65(HandleRef pThis);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004CEA RID: 19690 RVA: 0x00070440 File Offset: 0x0006E640
		public virtual int GetTimeStepStrideMaxValue()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetTimeStepStrideMaxValue_65(base.GetCppThis());
		}

		// Token: 0x06004CEB RID: 19691
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_GetTimeStepStrideMinValue_66(HandleRef pThis);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004CEC RID: 19692 RVA: 0x00070460 File Offset: 0x0006E660
		public virtual int GetTimeStepStrideMinValue()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetTimeStepStrideMinValue_66(base.GetCppThis());
		}

		// Token: 0x06004CED RID: 19693
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOSSWriter_GetWriteQAAndInformationRecords_67(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the writer will write quality assurance and
		/// information records.
		///
		/// These records are not copied from the input, but they are generated by the
		/// writer.
		/// </summary>
		// Token: 0x06004CEE RID: 19694 RVA: 0x00070480 File Offset: 0x0006E680
		public virtual bool GetWriteQAAndInformationRecords()
		{
			return vtkIOSSWriter.vtkIOSSWriter_GetWriteQAAndInformationRecords_67(base.GetCppThis()) != 0;
		}

		// Token: 0x06004CEF RID: 19695
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_IsA_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004CF0 RID: 19696 RVA: 0x000704A8 File Offset: 0x0006E6A8
		public override int IsA(string type)
		{
			return vtkIOSSWriter.vtkIOSSWriter_IsA_68(base.GetCppThis(), type);
		}

		// Token: 0x06004CF1 RID: 19697
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOSSWriter_IsTypeOf_69([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004CF2 RID: 19698 RVA: 0x000704C8 File Offset: 0x0006E6C8
		public new static int IsTypeOf(string type)
		{
			return vtkIOSSWriter.vtkIOSSWriter_IsTypeOf_69(type);
		}

		// Token: 0x06004CF3 RID: 19699
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_NewInstance_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004CF4 RID: 19700 RVA: 0x000704E4 File Offset: 0x0006E6E4
		public new vtkIOSSWriter NewInstance()
		{
			vtkIOSSWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_NewInstance_71(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIOSSWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004CF5 RID: 19701
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_OffsetGlobalIdsOff_72(HandleRef pThis);

		/// <summary>
		/// Exodus wants global ids to start with 1, while VTK generally produces
		/// global ids starting with 0. Set this to true (default false), if the global
		/// ids are generated by VTK and hence start with 0. When writing to the output
		/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
		/// </summary>
		// Token: 0x06004CF6 RID: 19702 RVA: 0x0007053E File Offset: 0x0006E73E
		public virtual void OffsetGlobalIdsOff()
		{
			vtkIOSSWriter.vtkIOSSWriter_OffsetGlobalIdsOff_72(base.GetCppThis());
		}

		// Token: 0x06004CF7 RID: 19703
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_OffsetGlobalIdsOn_73(HandleRef pThis);

		/// <summary>
		/// Exodus wants global ids to start with 1, while VTK generally produces
		/// global ids starting with 0. Set this to true (default false), if the global
		/// ids are generated by VTK and hence start with 0. When writing to the output
		/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
		/// </summary>
		// Token: 0x06004CF8 RID: 19704 RVA: 0x0007054D File Offset: 0x0006E74D
		public virtual void OffsetGlobalIdsOn()
		{
			vtkIOSSWriter.vtkIOSSWriter_OffsetGlobalIdsOn_73(base.GetCppThis());
		}

		// Token: 0x06004CF9 RID: 19705
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_PreserveOriginalIdsOff_74(HandleRef pThis);

		/// <summary>
		/// If input is transformed, e.g. through clipping, new element blocks may be created.
		/// This flag can be used to indicate whether to preserve the original ids from blocks.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004CFA RID: 19706 RVA: 0x0007055C File Offset: 0x0006E75C
		public virtual void PreserveOriginalIdsOff()
		{
			vtkIOSSWriter.vtkIOSSWriter_PreserveOriginalIdsOff_74(base.GetCppThis());
		}

		// Token: 0x06004CFB RID: 19707
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_PreserveOriginalIdsOn_75(HandleRef pThis);

		/// <summary>
		/// If input is transformed, e.g. through clipping, new element blocks may be created.
		/// This flag can be used to indicate whether to preserve the original ids from blocks.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004CFC RID: 19708 RVA: 0x0007056B File Offset: 0x0006E76B
		public virtual void PreserveOriginalIdsOn()
		{
			vtkIOSSWriter.vtkIOSSWriter_PreserveOriginalIdsOn_75(base.GetCppThis());
		}

		// Token: 0x06004CFD RID: 19709
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOSSWriter_SafeDownCast_76(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004CFE RID: 19710 RVA: 0x0007057C File Offset: 0x0006E77C
		public new static vtkIOSSWriter SafeDownCast(vtkObjectBase o)
		{
			vtkIOSSWriter vtkIOSSWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOSSWriter.vtkIOSSWriter_SafeDownCast_76((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIOSSWriter = (vtkIOSSWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIOSSWriter.Register(null);
				}
			}
			return vtkIOSSWriter;
		}

		// Token: 0x06004CFF RID: 19711
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetAssemblyName_77(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the active assembly to use. The chosen assembly is used
		/// in combination with the selectors specified to determine which blocks
		/// are to be extracted.
		///
		/// The default is set to vtkDataAssemblyUtilities::HierarchyName().
		/// </summary>
		// Token: 0x06004D00 RID: 19712 RVA: 0x000705FB File Offset: 0x0006E7FB
		public virtual void SetAssemblyName(string _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetAssemblyName_77(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D01 RID: 19713
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetChooseFieldsToWrite_78(HandleRef pThis, byte _arg);

		/// <summary>
		/// Choose which fields to write. If this is true, then only the
		/// arrays selected will be written. If this is false, then all arrays will be
		/// written.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004D02 RID: 19714 RVA: 0x0007060B File Offset: 0x0006E80B
		public virtual void SetChooseFieldsToWrite(bool _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetChooseFieldsToWrite_78(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004D03 RID: 19715
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetController_79(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the controller to use when working in parallel. Initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		///
		/// The controller is used to determine the upstream piece request in
		/// RequestUpdateExtent.
		/// </summary>
		// Token: 0x06004D04 RID: 19716 RVA: 0x00070624 File Offset: 0x0006E824
		public void SetController(vtkMultiProcessController controller)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetController_79(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x06004D05 RID: 19717
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetDisplacementMagnitude_80(HandleRef pThis, double _arg);

		/// <summary>
		/// If input dataset has displacements pre-applied, setting the displacement
		/// magnitude to non-zero ensures that the point coordinates in the dataset are
		/// correctly transformed using the displacement field array, if present.
		///
		/// Defaults to 1.0.
		/// </summary>
		// Token: 0x06004D06 RID: 19718 RVA: 0x00070653 File Offset: 0x0006E853
		public virtual void SetDisplacementMagnitude(double _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetDisplacementMagnitude_80(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D07 RID: 19719
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetEdgeBlockSelector_81(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get edge block selectors
		/// </summary>
		// Token: 0x06004D08 RID: 19720 RVA: 0x00070663 File Offset: 0x0006E863
		public void SetEdgeBlockSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetEdgeBlockSelector_81(base.GetCppThis(), selector);
		}

		// Token: 0x06004D09 RID: 19721
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetEdgeSetSelector_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004D0A RID: 19722 RVA: 0x00070673 File Offset: 0x0006E873
		public void SetEdgeSetSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetEdgeSetSelector_82(base.GetCppThis(), selector);
		}

		// Token: 0x06004D0B RID: 19723
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetElementBlockSelector_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get element block selectors
		/// </summary>
		// Token: 0x06004D0C RID: 19724 RVA: 0x00070683 File Offset: 0x0006E883
		public void SetElementBlockSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetElementBlockSelector_83(base.GetCppThis(), selector);
		}

		// Token: 0x06004D0D RID: 19725
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetElementSetSelector_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get element set selectors
		/// </summary>
		// Token: 0x06004D0E RID: 19726 RVA: 0x00070693 File Offset: 0x0006E893
		public void SetElementSetSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetElementSetSelector_84(base.GetCppThis(), selector);
		}

		// Token: 0x06004D0F RID: 19727
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetFaceBlockSelector_85(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get face block selectors
		/// </summary>
		// Token: 0x06004D10 RID: 19728 RVA: 0x000706A3 File Offset: 0x0006E8A3
		public void SetFaceBlockSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetFaceBlockSelector_85(base.GetCppThis(), selector);
		}

		// Token: 0x06004D11 RID: 19729
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetFaceSetSelector_86(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get edge set selectors
		/// </summary>
		// Token: 0x06004D12 RID: 19730 RVA: 0x000706B3 File Offset: 0x0006E8B3
		public void SetFaceSetSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetFaceSetSelector_86(base.GetCppThis(), selector);
		}

		// Token: 0x06004D13 RID: 19731
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetFileName_87(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/set the filename. When writing in a distributed environment, the
		/// actual filename written out may be different.
		/// </summary>
		// Token: 0x06004D14 RID: 19732 RVA: 0x000706C3 File Offset: 0x0006E8C3
		public virtual void SetFileName(string _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetFileName_87(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D15 RID: 19733
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetNodeSetSelector_88(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get node set selectors
		/// </summary>
		// Token: 0x06004D16 RID: 19734 RVA: 0x000706D3 File Offset: 0x0006E8D3
		public void SetNodeSetSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetNodeSetSelector_88(base.GetCppThis(), selector);
		}

		// Token: 0x06004D17 RID: 19735
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetOffsetGlobalIds_89(HandleRef pThis, byte _arg);

		/// <summary>
		/// Exodus wants global ids to start with 1, while VTK generally produces
		/// global ids starting with 0. Set this to true (default false), if the global
		/// ids are generated by VTK and hence start with 0. When writing to the output
		/// file, they will be offset by 1 to ensure the ids are valid exodus ids.
		/// </summary>
		// Token: 0x06004D18 RID: 19736 RVA: 0x000706E3 File Offset: 0x0006E8E3
		public virtual void SetOffsetGlobalIds(bool _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetOffsetGlobalIds_89(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004D19 RID: 19737
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetPreserveOriginalIds_90(HandleRef pThis, byte _arg);

		/// <summary>
		/// If input is transformed, e.g. through clipping, new element blocks may be created.
		/// This flag can be used to indicate whether to preserve the original ids from blocks.
		///
		/// The default is false.
		/// </summary>
		// Token: 0x06004D1A RID: 19738 RVA: 0x000706FB File Offset: 0x0006E8FB
		public virtual void SetPreserveOriginalIds(bool _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetPreserveOriginalIds_90(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004D1B RID: 19739
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetRemoveGhosts_91(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to write remove ghost cells from the input.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x06004D1C RID: 19740 RVA: 0x00070713 File Offset: 0x0006E913
		public virtual void SetRemoveGhosts(bool _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetRemoveGhosts_91(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004D1D RID: 19741
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetSelector_92(HandleRef pThis, vtkIOSSReader.EntityType entity, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Convenience method to set a single entity selector.
		/// This clears any other existing selectors.
		/// </summary>
		// Token: 0x06004D1E RID: 19742 RVA: 0x0007072B File Offset: 0x0006E92B
		public void SetSelector(vtkIOSSReader.EntityType entity, string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetSelector_92(base.GetCppThis(), entity, selector);
		}

		// Token: 0x06004D1F RID: 19743
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetSideSetSelector_93(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selector);

		/// <summary>
		/// Add/Clear/Set/Get side set selectors
		/// </summary>
		// Token: 0x06004D20 RID: 19744 RVA: 0x0007073C File Offset: 0x0006E93C
		public void SetSideSetSelector(string selector)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetSideSetSelector_93(base.GetCppThis(), selector);
		}

		// Token: 0x06004D21 RID: 19745
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetTimeStepRange_94(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004D22 RID: 19746 RVA: 0x0007074C File Offset: 0x0006E94C
		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetTimeStepRange_94(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06004D23 RID: 19747
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetTimeStepRange_95(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004D24 RID: 19748 RVA: 0x0007075D File Offset: 0x0006E95D
		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetTimeStepRange_95(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D25 RID: 19749
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetTimeStepStride_96(HandleRef pThis, int _arg);

		/// <summary>
		/// `TimeStepRange` and `TimeStepStride` can be used to limit which timesteps will be written.
		///
		/// If the range is invalid, i.e. `TimeStepRange[0] &gt;= TimeStepRange[1]`, it's assumed
		/// that no TimeStepRange overrides have been specified and both TimeStepRange and
		/// TimeStepStride will be ignored. When valid, only the chosen subset of files
		/// will be processed.
		/// </summary>
		// Token: 0x06004D26 RID: 19750 RVA: 0x0007076D File Offset: 0x0006E96D
		public virtual void SetTimeStepStride(int _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetTimeStepStride_96(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D27 RID: 19751
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_SetWriteQAAndInformationRecords_97(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default), the writer will write quality assurance and
		/// information records.
		///
		/// These records are not copied from the input, but they are generated by the
		/// writer.
		/// </summary>
		// Token: 0x06004D28 RID: 19752 RVA: 0x0007077D File Offset: 0x0006E97D
		public virtual void SetWriteQAAndInformationRecords(bool _arg)
		{
			vtkIOSSWriter.vtkIOSSWriter_SetWriteQAAndInformationRecords_97(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004D29 RID: 19753
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_WriteQAAndInformationRecordsOff_98(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the writer will write quality assurance and
		/// information records.
		///
		/// These records are not copied from the input, but they are generated by the
		/// writer.
		/// </summary>
		// Token: 0x06004D2A RID: 19754 RVA: 0x00070795 File Offset: 0x0006E995
		public virtual void WriteQAAndInformationRecordsOff()
		{
			vtkIOSSWriter.vtkIOSSWriter_WriteQAAndInformationRecordsOff_98(base.GetCppThis());
		}

		// Token: 0x06004D2B RID: 19755
		[DllImport("Kitware.VTK.IOIOSS.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIOSSWriter_WriteQAAndInformationRecordsOn_99(HandleRef pThis);

		/// <summary>
		/// When set to true (default), the writer will write quality assurance and
		/// information records.
		///
		/// These records are not copied from the input, but they are generated by the
		/// writer.
		/// </summary>
		// Token: 0x06004D2C RID: 19756 RVA: 0x000707A4 File Offset: 0x0006E9A4
		public virtual void WriteQAAndInformationRecordsOn()
		{
			vtkIOSSWriter.vtkIOSSWriter_WriteQAAndInformationRecordsOn_99(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000777 RID: 1911
		public new const string MRFullTypeName = "Kitware.VTK.vtkIOSSWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000778 RID: 1912
		public new static readonly string MRClassNameKey = "class vtkIOSSWriter";
	}
}
