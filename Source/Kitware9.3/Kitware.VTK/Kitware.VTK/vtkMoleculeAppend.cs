using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkMoleculeAppend
	/// </summary>
	/// <remarks>
	///  Appends one or more molecules into a single molecule
	///
	/// vtkMoleculeAppend appends molecule into a single molecule. It also appends
	/// the associated atom data and edge data.
	/// Note that input data arrays should match (same number of arrays with same names in each input)
	///
	/// Option MergeCoincidentAtoms specifies if coincident atoms should be merged or not.
	/// This may be useful in Parallel mode to remove ghost atoms when gather molecule on a rank.
	/// When merging, use the data of the non ghost atom. If none, use the data of the last coincident
	/// atom. This option is active by default.
	/// </remarks>
	// Token: 0x02000981 RID: 2433
	public class vtkMoleculeAppend : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019563 RID: 103779 RVA: 0x00234E63 File Offset: 0x00233063
		static vtkMoleculeAppend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeAppend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeAppend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019564 RID: 103780 RVA: 0x00234E8B File Offset: 0x0023308B
		public vtkMoleculeAppend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019565 RID: 103781
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAppend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019566 RID: 103782 RVA: 0x00234E9C File Offset: 0x0023309C
		public new static vtkMoleculeAppend New()
		{
			vtkMoleculeAppend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAppend.vtkMoleculeAppend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019567 RID: 103783 RVA: 0x00234EF0 File Offset: 0x002330F0
		public vtkMoleculeAppend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMoleculeAppend.vtkMoleculeAppend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019568 RID: 103784 RVA: 0x00234F34 File Offset: 0x00233134
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019569 RID: 103785
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAppend_GetInput_01(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x0601956A RID: 103786 RVA: 0x00234F40 File Offset: 0x00233140
		public new vtkDataObject GetInput(int idx)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAppend.vtkMoleculeAppend_GetInput_01(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601956B RID: 103787
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAppend_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x0601956C RID: 103788 RVA: 0x00234FB0 File Offset: 0x002331B0
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAppend.vtkMoleculeAppend_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601956D RID: 103789
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMoleculeAppend_GetMergeCoincidentAtoms_03(HandleRef pThis);

		/// <summary>
		/// Specify if coincident atoms (atom with exactly the same position)
		/// should be merged into one.
		/// True by default.
		/// </summary>
		// Token: 0x0601956E RID: 103790 RVA: 0x00235020 File Offset: 0x00233220
		public virtual bool GetMergeCoincidentAtoms()
		{
			return vtkMoleculeAppend.vtkMoleculeAppend_GetMergeCoincidentAtoms_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601956F RID: 103791
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeAppend_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019570 RID: 103792 RVA: 0x00235048 File Offset: 0x00233248
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeAppend.vtkMoleculeAppend_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06019571 RID: 103793
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeAppend_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019572 RID: 103794 RVA: 0x00235068 File Offset: 0x00233268
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeAppend.vtkMoleculeAppend_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06019573 RID: 103795
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeAppend_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019574 RID: 103796 RVA: 0x00235084 File Offset: 0x00233284
		public override int IsA(string type)
		{
			return vtkMoleculeAppend.vtkMoleculeAppend_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06019575 RID: 103797
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeAppend_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019576 RID: 103798 RVA: 0x002350A4 File Offset: 0x002332A4
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeAppend.vtkMoleculeAppend_IsTypeOf_07(type);
		}

		// Token: 0x06019577 RID: 103799
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAppend_MergeCoincidentAtomsOff_08(HandleRef pThis);

		/// <summary>
		/// Specify if coincident atoms (atom with exactly the same position)
		/// should be merged into one.
		/// True by default.
		/// </summary>
		// Token: 0x06019578 RID: 103800 RVA: 0x002350BE File Offset: 0x002332BE
		public virtual void MergeCoincidentAtomsOff()
		{
			vtkMoleculeAppend.vtkMoleculeAppend_MergeCoincidentAtomsOff_08(base.GetCppThis());
		}

		// Token: 0x06019579 RID: 103801
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAppend_MergeCoincidentAtomsOn_09(HandleRef pThis);

		/// <summary>
		/// Specify if coincident atoms (atom with exactly the same position)
		/// should be merged into one.
		/// True by default.
		/// </summary>
		// Token: 0x0601957A RID: 103802 RVA: 0x002350CD File Offset: 0x002332CD
		public virtual void MergeCoincidentAtomsOn()
		{
			vtkMoleculeAppend.vtkMoleculeAppend_MergeCoincidentAtomsOn_09(base.GetCppThis());
		}

		// Token: 0x0601957B RID: 103803
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAppend_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601957C RID: 103804 RVA: 0x002350DC File Offset: 0x002332DC
		public new vtkMoleculeAppend NewInstance()
		{
			vtkMoleculeAppend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAppend.vtkMoleculeAppend_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601957D RID: 103805
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAppend_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601957E RID: 103806 RVA: 0x00235138 File Offset: 0x00233338
		public new static vtkMoleculeAppend SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeAppend vtkMoleculeAppend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAppend.vtkMoleculeAppend_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeAppend = (vtkMoleculeAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeAppend.Register(null);
				}
			}
			return vtkMoleculeAppend;
		}

		// Token: 0x0601957F RID: 103807
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAppend_SetMergeCoincidentAtoms_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if coincident atoms (atom with exactly the same position)
		/// should be merged into one.
		/// True by default.
		/// </summary>
		// Token: 0x06019580 RID: 103808 RVA: 0x002351B7 File Offset: 0x002333B7
		public virtual void SetMergeCoincidentAtoms(bool _arg)
		{
			vtkMoleculeAppend.vtkMoleculeAppend_SetMergeCoincidentAtoms_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BC0 RID: 7104
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeAppend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BC1 RID: 7105
		public new static readonly string MRClassNameKey = "class vtkMoleculeAppend";
	}
}
