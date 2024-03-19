using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataRepresentation
	/// </summary>
	/// <remarks>
	///    The superclass for all representations
	///
	///
	/// vtkDataRepresentation the superclass for representations of data objects.
	/// This class itself may be instantiated and used as a representation
	/// that simply holds a connection to a pipeline.
	///
	/// If there are multiple representations present in a view, you should use
	/// a subclass of vtkDataRepresentation.  The representation is
	/// responsible for taking the input pipeline connection and converting it
	/// to an object usable by a view.  In the most common case, the representation
	/// will contain the pipeline necessary to convert a data object into an actor
	/// or set of actors.
	///
	/// The representation has a concept of a selection.  If the user performs a
	/// selection operation on the view, the view forwards this on to its
	/// representations.  The representation is responsible for displaying that
	/// selection in an appropriate way.
	///
	/// Representation selections may also be linked.  The representation shares
	/// the selection by converting it into a view-independent format, then
	/// setting the selection on its vtkAnnotationLink.  Other representations
	/// sharing the same selection link instance will get the same selection
	/// from the selection link when the view is updated.  The application is
	/// responsible for linking representations as appropriate by setting the
	/// same vtkAnnotationLink on each linked representation.
	/// </remarks>
	// Token: 0x02000078 RID: 120
	public class vtkDataRepresentation : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001650 RID: 5712 RVA: 0x000252FF File Offset: 0x000234FF
		static vtkDataRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001651 RID: 5713 RVA: 0x00025327 File Offset: 0x00023527
		public vtkDataRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001652 RID: 5714
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001653 RID: 5715 RVA: 0x00025338 File Offset: 0x00023538
		public new static vtkDataRepresentation New()
		{
			vtkDataRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001654 RID: 5716 RVA: 0x0002538C File Offset: 0x0002358C
		public vtkDataRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataRepresentation.vtkDataRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001655 RID: 5717 RVA: 0x000253D0 File Offset: 0x000235D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001656 RID: 5718
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_Annotate_01(HandleRef pThis, HandleRef view, HandleRef annotations);

		/// <summary>
		/// Analogous to Select(). The view calls this method when it needs to
		/// change the underlying annotations (some views might perform the
		/// creation of annotations). The representation takes the annotations
		/// and converts them into a selection on its data by calling ConvertAnnotations,
		/// then calls UpdateAnnotations with the converted selection.
		/// Subclasses should not override this method, but should instead
		/// override ConvertSelection.
		/// The optional third argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x06001657 RID: 5719 RVA: 0x000253DC File Offset: 0x000235DC
		public void Annotate(vtkView view, vtkAnnotationLayers annotations)
		{
			vtkDataRepresentation.vtkDataRepresentation_Annotate_01(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis());
		}

		// Token: 0x06001658 RID: 5720
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_Annotate_02(HandleRef pThis, HandleRef view, HandleRef annotations, byte extend);

		/// <summary>
		/// Analogous to Select(). The view calls this method when it needs to
		/// change the underlying annotations (some views might perform the
		/// creation of annotations). The representation takes the annotations
		/// and converts them into a selection on its data by calling ConvertAnnotations,
		/// then calls UpdateAnnotations with the converted selection.
		/// Subclasses should not override this method, but should instead
		/// override ConvertSelection.
		/// The optional third argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x06001659 RID: 5721 RVA: 0x00025420 File Offset: 0x00023620
		public void Annotate(vtkView view, vtkAnnotationLayers annotations, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_Annotate_02(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		// Token: 0x0600165A RID: 5722
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_ApplyViewTheme_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Apply a theme to this representation.
		/// Subclasses should override this method.
		/// </summary>
		// Token: 0x0600165B RID: 5723 RVA: 0x00025470 File Offset: 0x00023670
		public virtual void ApplyViewTheme(vtkViewTheme arg0)
		{
			vtkDataRepresentation.vtkDataRepresentation_ApplyViewTheme_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600165C RID: 5724
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_ConvertSelection_04(HandleRef pThis, HandleRef view, HandleRef selection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convert the selection to a type appropriate for sharing with other
		/// representations through vtkAnnotationLink, possibly using the view.
		/// For the superclass, we just return the same selection.
		/// Subclasses may do something more fancy, like convert the selection
		/// from a frustrum to a list of pedigree ids.  If the selection cannot
		/// be applied to this representation, return nullptr.
		/// </summary>
		// Token: 0x0600165D RID: 5725 RVA: 0x000254A0 File Offset: 0x000236A0
		public virtual vtkSelection ConvertSelection(vtkView view, vtkSelection selection)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_ConvertSelection_04(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x0600165E RID: 5726
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetAnnotationLink_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The annotation link for this representation.
		/// To link annotations, set the same vtkAnnotationLink object in
		/// multiple representations.
		/// </summary>
		// Token: 0x0600165F RID: 5727 RVA: 0x0002553C File Offset: 0x0002373C
		public vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetAnnotationLink_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		// Token: 0x06001660 RID: 5728
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInputConnection_06(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience override method for obtaining the input connection
		/// without specifying the port or index.
		/// </summary>
		// Token: 0x06001661 RID: 5729 RVA: 0x000255AC File Offset: 0x000237AC
		public new vtkAlgorithmOutput GetInputConnection(int port, int index)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInputConnection_06(base.GetCppThis(), port, index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001662 RID: 5730
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output port that contains the annotations whose selections are
		/// localized for a particular input data object.
		/// This should be used when connecting the internal pipelines.
		/// </summary>
		// Token: 0x06001663 RID: 5731 RVA: 0x00025620 File Offset: 0x00023820
		public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalAnnotationOutputPort_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001664 RID: 5732
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output port that contains the annotations whose selections are
		/// localized for a particular input data object.
		/// This should be used when connecting the internal pipelines.
		/// </summary>
		// Token: 0x06001665 RID: 5733 RVA: 0x00025690 File Offset: 0x00023890
		public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalAnnotationOutputPort_08(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001666 RID: 5734
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_09(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output port that contains the annotations whose selections are
		/// localized for a particular input data object.
		/// This should be used when connecting the internal pipelines.
		/// </summary>
		// Token: 0x06001667 RID: 5735 RVA: 0x00025700 File Offset: 0x00023900
		public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalAnnotationOutputPort_09(base.GetCppThis(), port, conn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001668 RID: 5736
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieves an output port for the input data object at the specified port
		/// and connection index. This may be connected to the representation's
		/// internal pipeline.
		/// </summary>
		// Token: 0x06001669 RID: 5737 RVA: 0x00025774 File Offset: 0x00023974
		public virtual vtkAlgorithmOutput GetInternalOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalOutputPort_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600166A RID: 5738
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieves an output port for the input data object at the specified port
		/// and connection index. This may be connected to the representation's
		/// internal pipeline.
		/// </summary>
		// Token: 0x0600166B RID: 5739 RVA: 0x000257E4 File Offset: 0x000239E4
		public virtual vtkAlgorithmOutput GetInternalOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalOutputPort_11(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600166C RID: 5740
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_12(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieves an output port for the input data object at the specified port
		/// and connection index. This may be connected to the representation's
		/// internal pipeline.
		/// </summary>
		// Token: 0x0600166D RID: 5741 RVA: 0x00025854 File Offset: 0x00023A54
		public virtual vtkAlgorithmOutput GetInternalOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalOutputPort_12(base.GetCppThis(), port, conn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600166E RID: 5742
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output port that contains the selection associated with the
		/// current annotation (normally the interactive selection).
		/// This should be used when connecting the internal pipelines.
		/// </summary>
		// Token: 0x0600166F RID: 5743 RVA: 0x000258C8 File Offset: 0x00023AC8
		public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalSelectionOutputPort_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001670 RID: 5744
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_14(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output port that contains the selection associated with the
		/// current annotation (normally the interactive selection).
		/// This should be used when connecting the internal pipelines.
		/// </summary>
		// Token: 0x06001671 RID: 5745 RVA: 0x00025938 File Offset: 0x00023B38
		public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalSelectionOutputPort_14(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001672 RID: 5746
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_15(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The output port that contains the selection associated with the
		/// current annotation (normally the interactive selection).
		/// This should be used when connecting the internal pipelines.
		/// </summary>
		// Token: 0x06001673 RID: 5747 RVA: 0x000259A8 File Offset: 0x00023BA8
		public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalSelectionOutputPort_15(base.GetCppThis(), port, conn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06001674 RID: 5748
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataRepresentation_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001675 RID: 5749 RVA: 0x00025A1C File Offset: 0x00023C1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataRepresentation.vtkDataRepresentation_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06001676 RID: 5750
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataRepresentation_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001677 RID: 5751 RVA: 0x00025A3C File Offset: 0x00023C3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataRepresentation.vtkDataRepresentation_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06001678 RID: 5752
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataRepresentation_GetSelectable_18(HandleRef pThis);

		/// <summary>
		/// Whether this representation is able to handle a selection.
		/// Default is true.
		/// </summary>
		// Token: 0x06001679 RID: 5753 RVA: 0x00025A58 File Offset: 0x00023C58
		public virtual bool GetSelectable()
		{
			return vtkDataRepresentation.vtkDataRepresentation_GetSelectable_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0600167A RID: 5754
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetSelectionArrayName_19(HandleRef pThis);

		/// <summary>
		/// If a VALUES selection, the array used to produce a selection.
		/// </summary>
		// Token: 0x0600167B RID: 5755 RVA: 0x00025A80 File Offset: 0x00023C80
		public virtual string GetSelectionArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataRepresentation.vtkDataRepresentation_GetSelectionArrayName_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600167C RID: 5756
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_GetSelectionArrayNames_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If a VALUES selection, the arrays used to produce a selection.
		/// </summary>
		// Token: 0x0600167D RID: 5757 RVA: 0x00025ABC File Offset: 0x00023CBC
		public virtual vtkStringArray GetSelectionArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetSelectionArrayNames_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600167E RID: 5758
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataRepresentation_GetSelectionType_21(HandleRef pThis);

		/// <summary>
		/// Set the selection type produced by this view.
		/// This should be one of the content type constants defined in
		/// vtkSelectionNode.h. Common values are
		/// vtkSelectionNode::INDICES
		/// vtkSelectionNode::PEDIGREEIDS
		/// vtkSelectionNode::VALUES
		/// </summary>
		// Token: 0x0600167F RID: 5759 RVA: 0x00025B2C File Offset: 0x00023D2C
		public virtual int GetSelectionType()
		{
			return vtkDataRepresentation.vtkDataRepresentation_GetSelectionType_21(base.GetCppThis());
		}

		// Token: 0x06001680 RID: 5760
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataRepresentation_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001681 RID: 5761 RVA: 0x00025B4C File Offset: 0x00023D4C
		public override int IsA(string type)
		{
			return vtkDataRepresentation.vtkDataRepresentation_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06001682 RID: 5762
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataRepresentation_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001683 RID: 5763 RVA: 0x00025B6C File Offset: 0x00023D6C
		public new static int IsTypeOf(string type)
		{
			return vtkDataRepresentation.vtkDataRepresentation_IsTypeOf_23(type);
		}

		// Token: 0x06001684 RID: 5764
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001685 RID: 5765 RVA: 0x00025B88 File Offset: 0x00023D88
		public new vtkDataRepresentation NewInstance()
		{
			vtkDataRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001686 RID: 5766
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001687 RID: 5767 RVA: 0x00025BE4 File Offset: 0x00023DE4
		public new static vtkDataRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x06001688 RID: 5768
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_Select_27(HandleRef pThis, HandleRef view, HandleRef selection);

		/// <summary>
		/// The view calls this method when a selection occurs.
		/// The representation takes this selection and converts it into
		/// a selection on its data by calling ConvertSelection,
		/// then calls UpdateSelection with the converted selection.
		/// Subclasses should not override this method, but should instead
		/// override ConvertSelection.
		/// The optional third argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x06001689 RID: 5769 RVA: 0x00025C64 File Offset: 0x00023E64
		public void Select(vtkView view, vtkSelection selection)
		{
			vtkDataRepresentation.vtkDataRepresentation_Select_27(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		// Token: 0x0600168A RID: 5770
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_Select_28(HandleRef pThis, HandleRef view, HandleRef selection, byte extend);

		/// <summary>
		/// The view calls this method when a selection occurs.
		/// The representation takes this selection and converts it into
		/// a selection on its data by calling ConvertSelection,
		/// then calls UpdateSelection with the converted selection.
		/// Subclasses should not override this method, but should instead
		/// override ConvertSelection.
		/// The optional third argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x0600168B RID: 5771 RVA: 0x00025CA8 File Offset: 0x00023EA8
		public void Select(vtkView view, vtkSelection selection, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_Select_28(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		// Token: 0x0600168C RID: 5772
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SelectableOff_29(HandleRef pThis);

		/// <summary>
		/// Whether this representation is able to handle a selection.
		/// Default is true.
		/// </summary>
		// Token: 0x0600168D RID: 5773 RVA: 0x00025CF5 File Offset: 0x00023EF5
		public virtual void SelectableOff()
		{
			vtkDataRepresentation.vtkDataRepresentation_SelectableOff_29(base.GetCppThis());
		}

		// Token: 0x0600168E RID: 5774
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SelectableOn_30(HandleRef pThis);

		/// <summary>
		/// Whether this representation is able to handle a selection.
		/// Default is true.
		/// </summary>
		// Token: 0x0600168F RID: 5775 RVA: 0x00025D04 File Offset: 0x00023F04
		public virtual void SelectableOn()
		{
			vtkDataRepresentation.vtkDataRepresentation_SelectableOn_30(base.GetCppThis());
		}

		// Token: 0x06001690 RID: 5776
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SetAnnotationLink_31(HandleRef pThis, HandleRef link);

		/// <summary>
		/// The annotation link for this representation.
		/// To link annotations, set the same vtkAnnotationLink object in
		/// multiple representations.
		/// </summary>
		// Token: 0x06001691 RID: 5777 RVA: 0x00025D14 File Offset: 0x00023F14
		public void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetAnnotationLink_31(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		// Token: 0x06001692 RID: 5778
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SetSelectable_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether this representation is able to handle a selection.
		/// Default is true.
		/// </summary>
		// Token: 0x06001693 RID: 5779 RVA: 0x00025D43 File Offset: 0x00023F43
		public virtual void SetSelectable(bool _arg)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectable_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001694 RID: 5780
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SetSelectionArrayName_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// If a VALUES selection, the array used to produce a selection.
		/// </summary>
		// Token: 0x06001695 RID: 5781 RVA: 0x00025D5B File Offset: 0x00023F5B
		public virtual void SetSelectionArrayName(string name)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectionArrayName_33(base.GetCppThis(), name);
		}

		// Token: 0x06001696 RID: 5782
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SetSelectionArrayNames_34(HandleRef pThis, HandleRef names);

		/// <summary>
		/// If a VALUES selection, the arrays used to produce a selection.
		/// </summary>
		// Token: 0x06001697 RID: 5783 RVA: 0x00025D6C File Offset: 0x00023F6C
		public virtual void SetSelectionArrayNames(vtkStringArray names)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectionArrayNames_34(base.GetCppThis(), (names == null) ? default(HandleRef) : names.GetCppThis());
		}

		// Token: 0x06001698 RID: 5784
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_SetSelectionType_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the selection type produced by this view.
		/// This should be one of the content type constants defined in
		/// vtkSelectionNode.h. Common values are
		/// vtkSelectionNode::INDICES
		/// vtkSelectionNode::PEDIGREEIDS
		/// vtkSelectionNode::VALUES
		/// </summary>
		// Token: 0x06001699 RID: 5785 RVA: 0x00025D9B File Offset: 0x00023F9B
		public virtual void SetSelectionType(int _arg)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectionType_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600169A RID: 5786
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_UpdateAnnotations_36(HandleRef pThis, HandleRef annotations);

		/// <summary>
		/// Updates the selection in the selection link and fires a selection
		/// change event. Subclasses should not override this method,
		/// but should instead override ConvertSelection.
		/// The optional second argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x0600169B RID: 5787 RVA: 0x00025DAC File Offset: 0x00023FAC
		public void UpdateAnnotations(vtkAnnotationLayers annotations)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateAnnotations_36(base.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis());
		}

		// Token: 0x0600169C RID: 5788
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_UpdateAnnotations_37(HandleRef pThis, HandleRef annotations, byte extend);

		/// <summary>
		/// Updates the selection in the selection link and fires a selection
		/// change event. Subclasses should not override this method,
		/// but should instead override ConvertSelection.
		/// The optional second argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x0600169D RID: 5789 RVA: 0x00025DDC File Offset: 0x00023FDC
		public void UpdateAnnotations(vtkAnnotationLayers annotations, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateAnnotations_37(base.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		// Token: 0x0600169E RID: 5790
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_UpdateSelection_38(HandleRef pThis, HandleRef selection);

		/// <summary>
		/// Updates the selection in the selection link and fires a selection
		/// change event. Subclasses should not override this method,
		/// but should instead override ConvertSelection.
		/// The optional second argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x0600169F RID: 5791 RVA: 0x00025E14 File Offset: 0x00024014
		public void UpdateSelection(vtkSelection selection)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateSelection_38(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		// Token: 0x060016A0 RID: 5792
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataRepresentation_UpdateSelection_39(HandleRef pThis, HandleRef selection, byte extend);

		/// <summary>
		/// Updates the selection in the selection link and fires a selection
		/// change event. Subclasses should not override this method,
		/// but should instead override ConvertSelection.
		/// The optional second argument specifies whether the selection should be
		/// added to the previous selection on this representation.
		/// </summary>
		// Token: 0x060016A1 RID: 5793 RVA: 0x00025E44 File Offset: 0x00024044
		public void UpdateSelection(vtkSelection selection, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateSelection_39(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000482 RID: 1154
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000483 RID: 1155
		public new static readonly string MRClassNameKey = "class vtkDataRepresentation";
	}
}
