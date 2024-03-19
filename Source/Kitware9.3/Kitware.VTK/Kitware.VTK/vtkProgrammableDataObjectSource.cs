using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgrammableDataObjectSource
	/// </summary>
	/// <remarks>
	///    generate source data object via a user-specified function
	///
	/// vtkProgrammableDataObjectSource is a source object that is programmable by
	/// the user. The output of the filter is a data object (vtkDataObject) which
	/// represents data via an instance of field data. To use this object, you
	/// must specify a function that creates the output.
	///
	/// Example use of this filter includes reading tabular data and encoding it
	/// as vtkFieldData. You can then use filters like vtkDataObjectToDataSetFilter
	/// to convert the data object to a dataset and then visualize it.  Another
	/// important use of this class is that it allows users of interpreters (e.g.,
	/// Java) the ability to write source objects without having to
	/// recompile C++ code or generate new libraries.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProgrammableFilter vtkProgrammableAttributeDataFilter
	/// vtkProgrammableSource vtkDataObjectToDataSetFilter
	/// </seealso>
	// Token: 0x0200083B RID: 2107
	public class vtkProgrammableDataObjectSource : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015CCE RID: 89294 RVA: 0x001EC1EF File Offset: 0x001EA3EF
		static vtkProgrammableDataObjectSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableDataObjectSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableDataObjectSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015CCF RID: 89295 RVA: 0x001EC217 File Offset: 0x001EA417
		public vtkProgrammableDataObjectSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015CD0 RID: 89296
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableDataObjectSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CD1 RID: 89297 RVA: 0x001EC228 File Offset: 0x001EA428
		public new static vtkProgrammableDataObjectSource New()
		{
			vtkProgrammableDataObjectSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CD2 RID: 89298 RVA: 0x001EC27C File Offset: 0x001EA47C
		public vtkProgrammableDataObjectSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015CD3 RID: 89299 RVA: 0x001EC2C0 File Offset: 0x001EA4C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015CD4 RID: 89300
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CD5 RID: 89301 RVA: 0x001EC2CC File Offset: 0x001EA4CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06015CD6 RID: 89302
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CD7 RID: 89303 RVA: 0x001EC2EC File Offset: 0x001EA4EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06015CD8 RID: 89304
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableDataObjectSource_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CD9 RID: 89305 RVA: 0x001EC308 File Offset: 0x001EA508
		public override int IsA(string type)
		{
			return vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06015CDA RID: 89306
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableDataObjectSource_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CDB RID: 89307 RVA: 0x001EC328 File Offset: 0x001EA528
		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_IsTypeOf_04(type);
		}

		// Token: 0x06015CDC RID: 89308
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableDataObjectSource_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CDD RID: 89309 RVA: 0x001EC344 File Offset: 0x001EA544
		public new vtkProgrammableDataObjectSource NewInstance()
		{
			vtkProgrammableDataObjectSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015CDE RID: 89310
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableDataObjectSource_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CDF RID: 89311 RVA: 0x001EC3A0 File Offset: 0x001EA5A0
		public new static vtkProgrammableDataObjectSource SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableDataObjectSource vtkProgrammableDataObjectSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableDataObjectSource = (vtkProgrammableDataObjectSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableDataObjectSource.Register(null);
				}
			}
			return vtkProgrammableDataObjectSource;
		}

		// Token: 0x06015CE0 RID: 89312
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableDataObjectSource_SetExecuteMethod_08(HandleRef pThis, vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f, IntPtr arg);

		/// <summary>
		/// Specify the function to use to generate the output data object. Note
		/// that the function takes a single (void *) argument.
		/// </summary>
		// Token: 0x06015CE1 RID: 89313 RVA: 0x001EC41F File Offset: 0x001EA61F
		public void SetExecuteMethod(vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_SetExecuteMethod_08(base.GetCppThis(), f, arg);
		}

		// Token: 0x06015CE2 RID: 89314
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableDataObjectSource_SetExecuteMethodArgDelete_09(HandleRef pThis, vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f);

		/// <summary>
		/// Set the arg delete method. This is used to free user memory.
		/// </summary>
		// Token: 0x06015CE3 RID: 89315 RVA: 0x001EC430 File Offset: 0x001EA630
		public void SetExecuteMethodArgDelete(vtkProgrammableDataObjectSource.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableDataObjectSource.vtkProgrammableDataObjectSource_SetExecuteMethodArgDelete_09(base.GetCppThis(), f);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018CD RID: 6349
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableDataObjectSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018CE RID: 6350
		public new static readonly string MRClassNameKey = "class vtkProgrammableDataObjectSource";

		/// <summary>
		/// Signature definition for programmable method callbacks. Methods passed to
		/// SetExecuteMethod or SetExecuteMethodArgDelete must conform to this
		/// signature.
		/// The presence of this typedef is useful for reference and for external
		/// analysis tools, but it cannot be used in the method signatures in these
		/// header files themselves because it prevents the internal VTK wrapper
		/// generators from wrapping these methods.
		/// </summary>
		// Token: 0x0200083C RID: 2108
		// (Invoke) Token: 0x06015CE5 RID: 89317
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);
	}
}
