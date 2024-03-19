using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkDataAssemblyUtilities
	/// </summary>
	/// <remarks>
	///  collections of utilities for vtkDataAssembly
	///
	/// vtkDataAssemblyUtilities provides useful utilities for working with
	/// vtkDataAssembly.
	/// </remarks>
	// Token: 0x02000A38 RID: 2616
	public class vtkDataAssemblyUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B430 RID: 111664 RVA: 0x00261619 File Offset: 0x0025F819
		static vtkDataAssemblyUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataAssemblyUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataAssemblyUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B431 RID: 111665 RVA: 0x00261641 File Offset: 0x0025F841
		public vtkDataAssemblyUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B432 RID: 111666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssemblyUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B433 RID: 111667 RVA: 0x00261650 File Offset: 0x0025F850
		public new static vtkDataAssemblyUtilities New()
		{
			vtkDataAssemblyUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataAssemblyUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B434 RID: 111668 RVA: 0x002616A4 File Offset: 0x0025F8A4
		public vtkDataAssemblyUtilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B435 RID: 111669 RVA: 0x002616E8 File Offset: 0x0025F8E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B436 RID: 111670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataAssemblyUtilities_GenerateHierarchy_01(HandleRef input, HandleRef hierarchy, HandleRef output);

		/// <summary>
		/// Populates `hierarchy` with a representation of the hierarchy for the given
		/// composite dataset `input`. A hierarchy represents the input dataset's
		/// structure as represented in the dataset itself.
		///
		/// If `output` is non-null, then the input is also
		/// converted to a `vtkPartitionedDataSetCollection`. The vtkDataAssembly on
		/// the `output` is updated to be a copy of the hierarchy with correct dataset
		/// indices so that relationships in the input blocks are preserved.
		///
		/// If input is not a `vtkMultiBlockDataSet`, `vtkPartitionedDataSetCollection`, or
		/// `vtkUniformGridAMR`, then there's no hierarchy to represent and hence this
		/// function will return `false`.
		/// </summary>
		// Token: 0x0601B437 RID: 111671 RVA: 0x002616F4 File Offset: 0x0025F8F4
		public static bool GenerateHierarchy(vtkCompositeDataSet input, vtkDataAssembly hierarchy, vtkPartitionedDataSetCollection output)
		{
			return vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_GenerateHierarchy_01((input == null) ? default(HandleRef) : input.GetCppThis(), (hierarchy == null) ? default(HandleRef) : hierarchy.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis()) != 0;
		}

		// Token: 0x0601B438 RID: 111672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B439 RID: 111673 RVA: 0x00261754 File Offset: 0x0025F954
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601B43A RID: 111674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B43B RID: 111675 RVA: 0x00261774 File Offset: 0x0025F974
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601B43C RID: 111676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDataAssemblyUtilities_GetSelectorForCompositeId_04(uint id, HandleRef hierarchy);

		/// <summary>
		/// For a vtkDataAssembly representing an hierarchy, returns the selector for
		/// the given composite id. Note, the selectors maybe best-match. When dealing
		/// with vtkPartitionedDataSetCollection, for example, a composite id may point
		/// to a particular dataset in a nested vtkPartitionedDataSet, however,
		/// selectors are simply not expressive enough to pick a dataset at that level
		/// and hence will simply point to the parent vtkPartitionedDataSet.
		/// </summary>
		// Token: 0x0601B43D RID: 111677 RVA: 0x00261790 File Offset: 0x0025F990
		public static string GetSelectorForCompositeId(uint id, vtkDataAssembly hierarchy)
		{
			return vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_GetSelectorForCompositeId_04(id, (hierarchy == null) ? default(HandleRef) : hierarchy.GetCppThis());
		}

		// Token: 0x0601B43E RID: 111678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssemblyUtilities_HierarchyName_05();

		/// <summary>
		/// Returns the named used by VTK to correspond to a vtkDataAssembly
		/// associated with the structure of a composite dataset.
		/// </summary>
		// Token: 0x0601B43F RID: 111679 RVA: 0x002617C0 File Offset: 0x0025F9C0
		public static string HierarchyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_HierarchyName_05());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B440 RID: 111680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssemblyUtilities_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B441 RID: 111681 RVA: 0x002617F4 File Offset: 0x0025F9F4
		public override int IsA(string type)
		{
			return vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B442 RID: 111682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssemblyUtilities_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B443 RID: 111683 RVA: 0x00261814 File Offset: 0x0025FA14
		public new static int IsTypeOf(string type)
		{
			return vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_IsTypeOf_07(type);
		}

		// Token: 0x0601B444 RID: 111684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssemblyUtilities_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B445 RID: 111685 RVA: 0x00261830 File Offset: 0x0025FA30
		public new vtkDataAssemblyUtilities NewInstance()
		{
			vtkDataAssemblyUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataAssemblyUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B446 RID: 111686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssemblyUtilities_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B447 RID: 111687 RVA: 0x0026188C File Offset: 0x0025FA8C
		public new static vtkDataAssemblyUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkDataAssemblyUtilities vtkDataAssemblyUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssemblyUtilities.vtkDataAssemblyUtilities_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataAssemblyUtilities = (vtkDataAssemblyUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataAssemblyUtilities.Register(null);
				}
			}
			return vtkDataAssemblyUtilities;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D64 RID: 7524
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataAssemblyUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D65 RID: 7525
		public new static readonly string MRClassNameKey = "class vtkDataAssemblyUtilities";
	}
}
