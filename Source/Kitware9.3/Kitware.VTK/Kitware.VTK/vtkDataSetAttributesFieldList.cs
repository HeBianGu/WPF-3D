using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkDataSetAttributesFieldList
	/// </summary>
	/// <remarks>
	///  helps manage arrays from multiple vtkDataSetAttributes.
	///
	/// vtkDataSetAttributesFieldList, also called vtkDataSetAttributes::FieldList,
	/// is used to help with filters when dealing with arrays from multiple
	/// vtkDataSetAttributes instances, potentially from multiple inputs.
	///
	/// Consider a filter that appends multiple inputs, e.g. vtkAppendPolyData.
	/// Besides appending mesh elements, such a filter also needs to combine field
	/// arrays (point, and cell data) from inputs to pass on to the output.
	/// Now if all the inputs had exactly the same set of arrays, we're all set.
	/// However, more often than not, the inputs will have different sets of arrays.
	/// The filter will need to match up from various inputs to combine together,
	/// potentially dropping arrays not in all inputs. Furthermore, it needs to
	/// ensure arrays in the output are flagged as attributes consistently. All of
	/// this can be done using vtkDataSetAttributesFieldList.
	///
	/// @section Usage Usage
	///
	/// Typical usage is as follows:
	/// 1. call `IntersectFieldList` or `UnionFieldList` for all input vtkDataSetAttributes
	///   instances,
	/// 2. allocate arrays for the output vtkDataSetAttributes by using `CopyAllocate`,
	/// 3. call `CopyData` per input (preserving the input order used in step 1) to
	///    copy tuple(s) from input to the output.
	///
	/// `vtkDataSetAttributes::InitializeFieldList` is provided for API compatibility
	/// with previous implementation of this class and it not required to be called.
	/// Simply calling `UnionFieldList` or `IntersectFieldList` for the first
	/// vtkDataSetAttributes instance is sufficient.
	///
	/// `CopyAllocate, `CopyData`, and `InterpolatePoint` methods on this class
	/// are called by similarly named variants on vtkDataSetAttributes that take in a
	/// FieldList instance as an argument. Hence, either forms may be used.
	///
	/// Calls to `UnionFieldList` and `IntersectFieldList` cannot be mixed. Use
	/// `Reset` or `InitializeFieldList` to change mode and start reinitialization.
	/// </remarks>
	// Token: 0x02000A3D RID: 2621
	public class vtkDataSetAttributesFieldList : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B4E1 RID: 111841 RVA: 0x00262AA2 File Offset: 0x00260CA2
		static vtkDataSetAttributesFieldList()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetAttributesFieldList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetAttributesFieldList"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B4E2 RID: 111842 RVA: 0x00262ACA File Offset: 0x00260CCA
		public vtkDataSetAttributesFieldList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B4E3 RID: 111843 RVA: 0x00262AD8 File Offset: 0x00260CD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B4E4 RID: 111844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_BuildPrototype_01(HandleRef pThis, HandleRef protoDSA, HandleRef ordering);

		/// <summary>
		/// A convenience function that builds a prototype / template dataset
		/// attributes for initializing the process of attribute interpolation and
		/// copying. The supplied protoPD should be initialized (empty), and the
		/// arrays present in this field list are instantiated and added to the
		/// prototype attributes. The typical usage is to use field list
		/// intersection (or union) operations to build up the field list, then
		/// create the prototype. Note, to retain an order of the data arrays,
		/// an optional ordering dataset attributes may be provided. (This is
		/// necessary because the vtkDataSetAttributesFieldList does not necessarily
		/// retain the original order of data arrays.)
		/// </summary>
		// Token: 0x0601B4E5 RID: 111845 RVA: 0x00262AE4 File Offset: 0x00260CE4
		public void BuildPrototype(vtkDataSetAttributes protoDSA, vtkDataSetAttributes ordering)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_BuildPrototype_01(base.GetCppThis(), (protoDSA == null) ? default(HandleRef) : protoDSA.GetCppThis(), (ordering == null) ? default(HandleRef) : ordering.GetCppThis());
		}

		// Token: 0x0601B4E6 RID: 111846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_CopyAllocate_02(HandleRef pThis, HandleRef output, int ctype, long sz, long ext);

		/// <summary>
		/// These methods can called to generate and update the output
		/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
		/// and can be called via the output vtkDataSetAttributes instance
		/// instead as well.
		/// </summary>
		// Token: 0x0601B4E7 RID: 111847 RVA: 0x00262B28 File Offset: 0x00260D28
		public void CopyAllocate(vtkDataSetAttributes output, int ctype, long sz, long ext)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_CopyAllocate_02(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), ctype, sz, ext);
		}

		// Token: 0x0601B4E8 RID: 111848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_CopyData_03(HandleRef pThis, int inputIndex, HandleRef input, long fromId, HandleRef output, long toId);

		/// <summary>
		/// These methods can called to generate and update the output
		/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
		/// and can be called via the output vtkDataSetAttributes instance
		/// instead as well.
		/// </summary>
		// Token: 0x0601B4E9 RID: 111849 RVA: 0x00262B5C File Offset: 0x00260D5C
		public void CopyData(int inputIndex, vtkDataSetAttributes input, long fromId, vtkDataSetAttributes output, long toId)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_CopyData_03(base.GetCppThis(), inputIndex, (input == null) ? default(HandleRef) : input.GetCppThis(), fromId, (output == null) ? default(HandleRef) : output.GetCppThis(), toId);
		}

		// Token: 0x0601B4EA RID: 111850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_CopyData_04(HandleRef pThis, int inputIndex, HandleRef input, long inputStart, long numValues, HandleRef output, long outStart);

		/// <summary>
		/// These methods can called to generate and update the output
		/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
		/// and can be called via the output vtkDataSetAttributes instance
		/// instead as well.
		/// </summary>
		// Token: 0x0601B4EB RID: 111851 RVA: 0x00262BA8 File Offset: 0x00260DA8
		public void CopyData(int inputIndex, vtkDataSetAttributes input, long inputStart, long numValues, vtkDataSetAttributes output, long outStart)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_CopyData_04(base.GetCppThis(), inputIndex, (input == null) ? default(HandleRef) : input.GetCppThis(), inputStart, numValues, (output == null) ? default(HandleRef) : output.GetCppThis(), outStart);
		}

		// Token: 0x0601B4EC RID: 111852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAttributesFieldList_GetNumberOfArrays_05(HandleRef pThis);

		/// <summary>
		/// This method can be used to determine the number of arrays remaining
		/// after intersection or union operations. See also
		/// vtkFieldData::GetNumberOfArrays().
		/// </summary>
		// Token: 0x0601B4ED RID: 111853 RVA: 0x00262BF4 File Offset: 0x00260DF4
		public int GetNumberOfArrays()
		{
			return vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_GetNumberOfArrays_05(base.GetCppThis());
		}

		// Token: 0x0601B4EE RID: 111854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_InitializeFieldList_06(HandleRef pThis, HandleRef dsa);

		/// <summary>
		/// Initialize the field list. This also adds the first input.
		/// Calling this method is optional. The first call to `IntersectFieldList` or
		/// `UnionFieldList` on a new instance or after calling `Reset()` will have the
		/// same effect.
		/// </summary>
		// Token: 0x0601B4EF RID: 111855 RVA: 0x00262C14 File Offset: 0x00260E14
		public void InitializeFieldList(vtkDataSetAttributes dsa)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_InitializeFieldList_06(base.GetCppThis(), (dsa == null) ? default(HandleRef) : dsa.GetCppThis());
		}

		// Token: 0x0601B4F0 RID: 111856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_InterpolatePoint_07(HandleRef pThis, int inputIndex, HandleRef input, HandleRef inputIds, IntPtr weights, HandleRef output, long toId);

		/// <summary>
		/// These methods can called to generate and update the output
		/// vtkDataSetAttributes. These match corresponding API on vtkDataSetAttributes
		/// and can be called via the output vtkDataSetAttributes instance
		/// instead as well.
		/// </summary>
		// Token: 0x0601B4F1 RID: 111857 RVA: 0x00262C44 File Offset: 0x00260E44
		public void InterpolatePoint(int inputIndex, vtkDataSetAttributes input, vtkIdList inputIds, IntPtr weights, vtkDataSetAttributes output, long toId)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_InterpolatePoint_07(base.GetCppThis(), inputIndex, (input == null) ? default(HandleRef) : input.GetCppThis(), (inputIds == null) ? default(HandleRef) : inputIds.GetCppThis(), weights, (output == null) ? default(HandleRef) : output.GetCppThis(), toId);
		}

		// Token: 0x0601B4F2 RID: 111858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_IntersectFieldList_08(HandleRef pThis, HandleRef dsa);

		/// <summary>
		/// Update the field list for an intersection of arrays registered so far and
		/// those in `dsa`.
		/// </summary>
		// Token: 0x0601B4F3 RID: 111859 RVA: 0x00262CA4 File Offset: 0x00260EA4
		public void IntersectFieldList(vtkDataSetAttributes dsa)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_IntersectFieldList_08(base.GetCppThis(), (dsa == null) ? default(HandleRef) : dsa.GetCppThis());
		}

		// Token: 0x0601B4F4 RID: 111860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_Reset_09(HandleRef pThis);

		/// <summary>
		/// Initializes the field list to empty.
		/// </summary>
		// Token: 0x0601B4F5 RID: 111861 RVA: 0x00262CD3 File Offset: 0x00260ED3
		public void Reset()
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_Reset_09(base.GetCppThis());
		}

		// Token: 0x0601B4F6 RID: 111862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAttributesFieldList_UnionFieldList_10(HandleRef pThis, HandleRef dsa);

		/// <summary>
		/// Update the field list for an union of arrays registered so far and
		/// those in `dsa`.
		/// </summary>
		// Token: 0x0601B4F7 RID: 111863 RVA: 0x00262CE4 File Offset: 0x00260EE4
		public void UnionFieldList(vtkDataSetAttributes dsa)
		{
			vtkDataSetAttributesFieldList.vtkDataSetAttributesFieldList_UnionFieldList_10(base.GetCppThis(), (dsa == null) ? default(HandleRef) : dsa.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D6E RID: 7534
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetAttributesFieldList";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D6F RID: 7535
		public new static readonly string MRClassNameKey = "class vtkDataSetAttributesFieldList";
	}
}
