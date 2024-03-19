using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgrammableSource
	/// </summary>
	/// <remarks>
	///    generate source dataset via a user-specified function
	///
	/// vtkProgrammableSource is a source object that is programmable by the
	/// user. To use this object, you must specify a function that creates the
	/// output.  It is possible to generate an output dataset of any (concrete)
	/// type; it is up to the function to properly initialize and define the
	/// output. Typically, you use one of the methods to get a concrete output
	/// type (e.g., GetPolyDataOutput() or GetStructuredPointsOutput()), and
	/// then manipulate the output in the user-specified function.
	///
	/// Example use of this include writing a function to read a data file or
	/// interface to another system. (You might want to do this in favor of
	/// deriving a new class.) Another important use of this class is that it
	/// allows users of interpreters (e.g., Java) the ability to write
	/// source objects without having to recompile C++ code or generate new
	/// libraries.
	/// </remarks>
	/// <seealso>
	///
	/// vtkProgrammableFilter vtkProgrammableAttributeDataFilter
	/// vtkProgrammableDataObjectSource
	/// </seealso>
	// Token: 0x0200083D RID: 2109
	public class vtkProgrammableSource : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015CE8 RID: 89320 RVA: 0x001EC440 File Offset: 0x001EA640
		static vtkProgrammableSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015CE9 RID: 89321 RVA: 0x001EC468 File Offset: 0x001EA668
		public vtkProgrammableSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015CEA RID: 89322
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CEB RID: 89323 RVA: 0x001EC478 File Offset: 0x001EA678
		public new static vtkProgrammableSource New()
		{
			vtkProgrammableSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CEC RID: 89324 RVA: 0x001EC4CC File Offset: 0x001EA6CC
		public vtkProgrammableSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgrammableSource.vtkProgrammableSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015CED RID: 89325 RVA: 0x001EC510 File Offset: 0x001EA710
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015CEE RID: 89326
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetGraphOutput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CEF RID: 89327 RVA: 0x001EC51C File Offset: 0x001EA71C
		public vtkGraph GetGraphOutput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetGraphOutput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06015CF0 RID: 89328
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetMoleculeOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CF1 RID: 89329 RVA: 0x001EC58C File Offset: 0x001EA78C
		public vtkMolecule GetMoleculeOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetMoleculeOutput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x06015CF2 RID: 89330
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CF3 RID: 89331 RVA: 0x001EC5FC File Offset: 0x001EA7FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgrammableSource.vtkProgrammableSource_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06015CF4 RID: 89332
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableSource_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CF5 RID: 89333 RVA: 0x001EC61C File Offset: 0x001EA81C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgrammableSource.vtkProgrammableSource_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06015CF6 RID: 89334
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetPolyDataOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CF7 RID: 89335 RVA: 0x001EC638 File Offset: 0x001EA838
		public vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetPolyDataOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06015CF8 RID: 89336
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetRectilinearGridOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CF9 RID: 89337 RVA: 0x001EC6A8 File Offset: 0x001EA8A8
		public vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetRectilinearGridOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06015CFA RID: 89338
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetStructuredGridOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CFB RID: 89339 RVA: 0x001EC718 File Offset: 0x001EA918
		public vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetStructuredGridOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06015CFC RID: 89340
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetStructuredPointsOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CFD RID: 89341 RVA: 0x001EC788 File Offset: 0x001EA988
		public vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetStructuredPointsOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x06015CFE RID: 89342
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetTableOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015CFF RID: 89343 RVA: 0x001EC7F8 File Offset: 0x001EA9F8
		public vtkTable GetTableOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetTableOutput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06015D00 RID: 89344
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_GetUnstructuredGridOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type. This method is typically used by the
		/// writer of the source function to get the output as a particular type
		/// (i.e., it essentially does type casting). It is the users responsibility
		/// to know the correct type of the output data.
		/// </summary>
		// Token: 0x06015D01 RID: 89345 RVA: 0x001EC868 File Offset: 0x001EAA68
		public vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_GetUnstructuredGridOutput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06015D02 RID: 89346
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableSource_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D03 RID: 89347 RVA: 0x001EC8D8 File Offset: 0x001EAAD8
		public override int IsA(string type)
		{
			return vtkProgrammableSource.vtkProgrammableSource_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06015D04 RID: 89348
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableSource_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D05 RID: 89349 RVA: 0x001EC8F8 File Offset: 0x001EAAF8
		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableSource.vtkProgrammableSource_IsTypeOf_12(type);
		}

		// Token: 0x06015D06 RID: 89350
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D07 RID: 89351 RVA: 0x001EC914 File Offset: 0x001EAB14
		public new vtkProgrammableSource NewInstance()
		{
			vtkProgrammableSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015D08 RID: 89352
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableSource_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015D09 RID: 89353 RVA: 0x001EC970 File Offset: 0x001EAB70
		public new static vtkProgrammableSource SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableSource vtkProgrammableSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableSource.vtkProgrammableSource_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableSource = (vtkProgrammableSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableSource.Register(null);
				}
			}
			return vtkProgrammableSource;
		}

		// Token: 0x06015D0A RID: 89354
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableSource_SetExecuteMethod_16(HandleRef pThis, vtkProgrammableSource.ProgrammableMethodCallbackType f, IntPtr arg);

		/// <summary>
		/// Specify the function to use to generate the source data. Note
		/// that the function takes a single (void *) argument.
		/// </summary>
		// Token: 0x06015D0B RID: 89355 RVA: 0x001EC9EF File Offset: 0x001EABEF
		public void SetExecuteMethod(vtkProgrammableSource.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableSource.vtkProgrammableSource_SetExecuteMethod_16(base.GetCppThis(), f, arg);
		}

		// Token: 0x06015D0C RID: 89356
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableSource_SetExecuteMethodArgDelete_17(HandleRef pThis, vtkProgrammableSource.ProgrammableMethodCallbackType f);

		/// <summary>
		/// Set the arg delete method. This is used to free user memory.
		/// </summary>
		// Token: 0x06015D0D RID: 89357 RVA: 0x001ECA00 File Offset: 0x001EAC00
		public void SetExecuteMethodArgDelete(vtkProgrammableSource.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableSource.vtkProgrammableSource_SetExecuteMethodArgDelete_17(base.GetCppThis(), f);
		}

		// Token: 0x06015D0E RID: 89358
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableSource_SetRequestInformationMethod_18(HandleRef pThis, vtkProgrammableSource.ProgrammableMethodCallbackType f);

		/// <summary>
		/// Specify the function to use to fill in information about the source data.
		/// </summary>
		// Token: 0x06015D0F RID: 89359 RVA: 0x001ECA10 File Offset: 0x001EAC10
		public void SetRequestInformationMethod(vtkProgrammableSource.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableSource.vtkProgrammableSource_SetRequestInformationMethod_18(base.GetCppThis(), f);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018CF RID: 6351
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018D0 RID: 6352
		public new static readonly string MRClassNameKey = "class vtkProgrammableSource";

		/// <summary>
		/// Signature definition for programmable method callbacks. Methods passed
		/// to SetExecuteMethod, SetExecuteMethodArgDelete or
		/// SetRequestInformationMethod must conform to this signature.
		/// The presence of this typedef is useful for reference and for external
		/// analysis tools, but it cannot be used in the method signatures in these
		/// header files themselves because it prevents the internal VTK wrapper
		/// generators from wrapping these methods.
		/// </summary>
		// Token: 0x0200083E RID: 2110
		// (Invoke) Token: 0x06015D11 RID: 89361
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);
	}
}
