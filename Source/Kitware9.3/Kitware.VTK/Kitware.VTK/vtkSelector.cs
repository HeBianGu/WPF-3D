using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSelector.h
	/// </summary>
	/// <remarks>
	///    Computes the portion of a dataset which is inside a selection
	///
	/// This is an abstract superclass for types of selection operations. Subclasses
	/// generally only need to override `ComputeSelectedElements`.
	/// </remarks>
	// Token: 0x020006A2 RID: 1698
	public abstract class vtkSelector : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060122AB RID: 74411 RVA: 0x00196FC3 File Offset: 0x001951C3
		static vtkSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060122AC RID: 74412 RVA: 0x00196FEB File Offset: 0x001951EB
		public vtkSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060122AD RID: 74413 RVA: 0x00196FF9 File Offset: 0x001951F9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060122AE RID: 74414
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelector_Execute_01(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Given an input and the vtkSelectionNode passed into the Initialize() method, add to the
		/// output a vtkSignedChar attribute array indicating whether each element is inside (1)
		/// or outside (0) the selection. The attribute (point data or cell data) is determined
		/// by the vtkSelection that owns the vtkSelectionNode set in Initialize(). The insidedness
		/// array is named with the value of InsidednessArrayName. If input is a vtkCompositeDataSet,
		/// the insidedness array is added to each block.
		///
		/// </summary>
		// Token: 0x060122AF RID: 74415 RVA: 0x00197004 File Offset: 0x00195204
		public virtual void Execute(vtkDataObject input, vtkDataObject output)
		{
			vtkSelector.vtkSelector_Execute_01(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x060122B0 RID: 74416
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelector_Finalize_02(HandleRef pThis);

		/// <summary>
		/// Does any cleanup of objects created in Initialize
		/// </summary>
		// Token: 0x060122B1 RID: 74417 RVA: 0x00197048 File Offset: 0x00195248
		public virtual void FinalizeWrapper()
		{
			vtkSelector.vtkSelector_Finalize_02(base.GetCppThis());
		}

		// Token: 0x060122B2 RID: 74418
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSelector_GetInsidednessArrayName_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the array to use for the insidedness array to add to
		/// the output in `Execute` call.
		/// </summary>
		// Token: 0x060122B3 RID: 74419 RVA: 0x00197058 File Offset: 0x00195258
		public virtual string GetInsidednessArrayName()
		{
			return vtkSelector.vtkSelector_GetInsidednessArrayName_03(base.GetCppThis());
		}

		// Token: 0x060122B4 RID: 74420
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelector_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122B5 RID: 74421 RVA: 0x00197078 File Offset: 0x00195278
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSelector.vtkSelector_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060122B6 RID: 74422
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSelector_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122B7 RID: 74423 RVA: 0x00197098 File Offset: 0x00195298
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSelector.vtkSelector_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060122B8 RID: 74424
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelector_Initialize_06(HandleRef pThis, HandleRef node);

		/// <summary>
		/// Sets the vtkSelectionNode used by this selection operator and initializes
		/// the data structures in the selection operator based on the selection.
		///
		/// (for example in the vtkFrustumSelector this creates the vtkPlanes
		/// implicit function to represent the frustum).
		///
		/// @param node The selection node that determines the behavior of this operator.
		/// </summary>
		// Token: 0x060122B9 RID: 74425 RVA: 0x001970B4 File Offset: 0x001952B4
		public virtual void Initialize(vtkSelectionNode node)
		{
			vtkSelector.vtkSelector_Initialize_06(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		// Token: 0x060122BA RID: 74426
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelector_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122BB RID: 74427 RVA: 0x001970E4 File Offset: 0x001952E4
		public override int IsA(string type)
		{
			return vtkSelector.vtkSelector_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060122BC RID: 74428
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSelector_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122BD RID: 74429 RVA: 0x00197104 File Offset: 0x00195304
		public new static int IsTypeOf(string type)
		{
			return vtkSelector.vtkSelector_IsTypeOf_08(type);
		}

		// Token: 0x060122BE RID: 74430
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122BF RID: 74431 RVA: 0x00197120 File Offset: 0x00195320
		public new vtkSelector NewInstance()
		{
			vtkSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelector.vtkSelector_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060122C0 RID: 74432
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSelector_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060122C1 RID: 74433 RVA: 0x0019717C File Offset: 0x0019537C
		public new static vtkSelector SafeDownCast(vtkObjectBase o)
		{
			vtkSelector vtkSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSelector.vtkSelector_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelector = (vtkSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelector.Register(null);
				}
			}
			return vtkSelector;
		}

		// Token: 0x060122C2 RID: 74434
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSelector_SetInsidednessArrayName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the array to use for the insidedness array to add to
		/// the output in `Execute` call.
		/// </summary>
		// Token: 0x060122C3 RID: 74435 RVA: 0x001971FB File Offset: 0x001953FB
		public virtual void SetInsidednessArrayName(string _arg)
		{
			vtkSelector.vtkSelector_SetInsidednessArrayName_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F2 RID: 5362
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014F3 RID: 5363
		public new static readonly string MRClassNameKey = "class vtkSelector";
	}
}
