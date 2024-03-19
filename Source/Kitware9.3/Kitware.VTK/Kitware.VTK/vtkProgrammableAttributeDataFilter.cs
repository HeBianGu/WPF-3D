using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgrammableAttributeDataFilter
	/// </summary>
	/// <remarks>
	///    manipulate attribute (cell and point) data via a user-specified function
	///
	/// vtkProgrammableAttributeDataFilter is a filter that allows you to write a
	/// custom procedure to manipulate attribute data - either point or cell
	/// data. For example, you could generate scalars based on a complex formula;
	/// convert vectors to normals; compute scalar values as a function of
	/// vectors, texture coords, and/or any other point data attribute; and so
	/// on. The filter takes multiple inputs (input plus an auxiliary input list),
	/// so you can write procedures that combine several dataset point
	/// attributes. Note that the output of the filter is the same type
	/// (topology/geometry) as the input.
	///
	/// The filter works as follows. It operates like any other filter (i.e.,
	/// checking and managing modified and execution times, processing Update()
	/// and Execute() methods, managing release of data, etc.), but the difference
	/// is that the Execute() method simply invokes a user-specified function with
	/// an optional (void *) argument (typically the "this" pointer in C++). It is
	/// also possible to specify a function to delete the argument via
	/// ExecuteMethodArgDelete().
	///
	/// To use the filter, you write a procedure to process the input datasets,
	/// process the data, and generate output data. Typically, this means grabbing
	/// the input point or cell data (using GetInput() and maybe GetInputList()),
	/// operating on it (creating new point and cell attributes such as scalars,
	/// vectors, etc.), and then setting the point and/or cell attributes in the
	/// output dataset (you'll need to use GetOutput() to access the output).
	/// (Note: besides C++, it is possible to do the same thing in Java or
	/// other languages that wrap the C++ core.) Remember, proper filter protocol
	/// requires that you don't modify the input data - you create new output data
	/// from the input.
	///
	/// @warning
	/// This filter operates on any combination of the filter input plus a list of
	/// additional inputs (at a minimum you must set the filter input via
	/// SetInput()).  It is up to you check whether the input is valid, and to
	/// ensure that the output is valid. Also, you have to write the control
	/// structure for the traversal and operation on the point and cell attribute
	/// data.
	///
	/// @warning
	/// By default the output point and cell data will be copied through from the
	/// input point data (using reference counting).  You can control this using
	/// the output's CopyAllOff() flag, or by using individual flags for each
	/// point data field (i.e., scalars, vectors, etc.)
	///
	/// @warning
	/// The output of this filter is the abstract type vtkDataSet, even if your
	/// input is a concrete type like vtkPolyData. Thus you may need to use
	/// vtkCastToConcrete to obtain the output as a particular concrete type, or
	/// one of the special methods of the superclass (e.g.,
	/// vtkDataSetAlgorithm::GetPolyDataOutput) to retrieve output of the
	/// correct type.
	///
	/// @warning
	/// The filter correctly manages modified time and network execution in most
	/// cases. However, if you change the definition of the filter function,
	/// you'll want to send a manual Modified() method to the filter to force it
	/// to reexecute.
	/// </remarks>
	// Token: 0x0200042C RID: 1068
	public class vtkProgrammableAttributeDataFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C879 RID: 51321 RVA: 0x00117267 File Offset: 0x00115467
		static vtkProgrammableAttributeDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableAttributeDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableAttributeDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C87A RID: 51322 RVA: 0x0011728F File Offset: 0x0011548F
		public vtkProgrammableAttributeDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C87B RID: 51323
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C87C RID: 51324 RVA: 0x001172A0 File Offset: 0x001154A0
		public new static vtkProgrammableAttributeDataFilter New()
		{
			vtkProgrammableAttributeDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C87D RID: 51325 RVA: 0x001172F4 File Offset: 0x001154F4
		public vtkProgrammableAttributeDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C87E RID: 51326 RVA: 0x00117338 File Offset: 0x00115538
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C87F RID: 51327
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableAttributeDataFilter_AddInput_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a dataset to the list of data to process.
		/// </summary>
		// Token: 0x0600C880 RID: 51328 RVA: 0x00117344 File Offset: 0x00115544
		public void AddInput(vtkDataSet arg0)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C881 RID: 51329
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_GetInputList_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the list of inputs.
		/// </summary>
		// Token: 0x0600C882 RID: 51330 RVA: 0x00117374 File Offset: 0x00115574
		public vtkDataSetCollection GetInputList()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_GetInputList_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		// Token: 0x0600C883 RID: 51331
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C884 RID: 51332 RVA: 0x001173E4 File Offset: 0x001155E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C885 RID: 51333
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C886 RID: 51334 RVA: 0x00117404 File Offset: 0x00115604
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C887 RID: 51335
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableAttributeDataFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C888 RID: 51336 RVA: 0x00117420 File Offset: 0x00115620
		public override int IsA(string type)
		{
			return vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C889 RID: 51337
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableAttributeDataFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C88A RID: 51338 RVA: 0x00117440 File Offset: 0x00115640
		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_IsTypeOf_06(type);
		}

		// Token: 0x0600C88B RID: 51339
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C88C RID: 51340 RVA: 0x0011745C File Offset: 0x0011565C
		public new vtkProgrammableAttributeDataFilter NewInstance()
		{
			vtkProgrammableAttributeDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C88D RID: 51341
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableAttributeDataFilter_RemoveInput_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a dataset from the list of data to process.
		/// </summary>
		// Token: 0x0600C88E RID: 51342 RVA: 0x001174B8 File Offset: 0x001156B8
		public void RemoveInput(vtkDataSet arg0)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_RemoveInput_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C88F RID: 51343
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableAttributeDataFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C890 RID: 51344 RVA: 0x001174E8 File Offset: 0x001156E8
		public new static vtkProgrammableAttributeDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableAttributeDataFilter vtkProgrammableAttributeDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableAttributeDataFilter = (vtkProgrammableAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableAttributeDataFilter.Register(null);
				}
			}
			return vtkProgrammableAttributeDataFilter;
		}

		// Token: 0x0600C891 RID: 51345
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethod_11(HandleRef pThis, vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f, IntPtr arg);

		/// <summary>
		/// Specify the function to use to operate on the point attribute data. Note
		/// that the function takes a single (void *) argument.
		/// </summary>
		// Token: 0x0600C892 RID: 51346 RVA: 0x00117567 File Offset: 0x00115767
		public void SetExecuteMethod(vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethod_11(base.GetCppThis(), f, arg);
		}

		// Token: 0x0600C893 RID: 51347
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethodArgDelete_12(HandleRef pThis, vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f);

		/// <summary>
		/// Set the arg delete method. This is used to free user memory.
		/// </summary>
		// Token: 0x0600C894 RID: 51348 RVA: 0x00117578 File Offset: 0x00115778
		public void SetExecuteMethodArgDelete(vtkProgrammableAttributeDataFilter.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethodArgDelete_12(base.GetCppThis(), f);
		}

		// Token: 0x0600C895 RID: 51349
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableAttributeDataFilter_SetExecuteMethod(HandleRef pThis, vtkProgrammableAttributeDataFilter.ExecuteMethodHandler handler, IntPtr arg);

		/// <summary>
		/// Specify the function to use to operate on the point attribute data. Note
		/// that the function takes a single (void *) argument.
		/// </summary>
		// Token: 0x0600C896 RID: 51350 RVA: 0x00117588 File Offset: 0x00115788
		public void SetExecuteMethod(vtkProgrammableAttributeDataFilter.ExecuteMethodHandler handler, IntPtr arg)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethod(base.GetCppThis(), handler, arg);
		}

		/// <summary>
		/// Specify the function to use to operate on the point attribute data. Note
		/// that the function takes a single (void *) argument.
		/// </summary>
		// Token: 0x0600C897 RID: 51351 RVA: 0x00117599 File Offset: 0x00115799
		public void SetExecuteMethod(vtkProgrammableAttributeDataFilter.ExecuteMethodHandler handler)
		{
			vtkProgrammableAttributeDataFilter.vtkProgrammableAttributeDataFilter_SetExecuteMethod(base.GetCppThis(), handler, IntPtr.Zero);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE9 RID: 3817
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableAttributeDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EEA RID: 3818
		public new static readonly string MRClassNameKey = "class vtkProgrammableAttributeDataFilter";

		/// <summary>
		/// Signature definition for programmable method callbacks. Methods passed to
		/// SetExecuteMethod or SetExecuteMethodArgDelete must conform to this
		/// signature.
		/// The presence of this typedef is useful for reference and for external
		/// analysis tools, but it cannot be used in the method signatures in these
		/// header files themselves because it prevents the internal VTK wrapper
		/// generators from wrapping these methods.
		/// </summary>
		// Token: 0x0200042D RID: 1069
		// (Invoke) Token: 0x0600C899 RID: 51353
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);

		/// <summary>
		/// Managed/.NET signature for handlers of the SetExecuteMethod callback.
		/// </summary>
		// Token: 0x0200042E RID: 1070
		// (Invoke) Token: 0x0600C89D RID: 51357
		public delegate void ExecuteMethodHandler(IntPtr arg);
	}
}
