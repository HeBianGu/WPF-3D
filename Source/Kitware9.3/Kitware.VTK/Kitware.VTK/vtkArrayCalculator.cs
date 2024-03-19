using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayCalculator
	/// </summary>
	/// <remarks>
	///    perform mathematical operations on data in field data arrays
	///
	/// vtkArrayCalculator performs operations on vectors or scalars in field
	/// data arrays.  It uses vtkFunctionParser/vtkExprTkFunctionParser to do
	/// the parsing and to evaluate the function for each entry in the input
	/// arrays.  The arrays used in a given function must be all in point data
	/// or all in cell data. The resulting array will be stored as a field
	/// data array.  The result array can either be stored in a new array or
	/// it can overwrite an existing array. vtkArrayCalculator can run in
	/// parallel using vtkSMPTools.
	///
	/// The functions that this array calculator understands is:
	///
	/// standard operations:
	/// +
	/// -
	/// *
	/// /
	/// ^
	/// . (only by vtkFunctionParser)
	/// build unit vectors: iHat, jHat, kHat (ie (1,0,0), (0,1,0), (0,0,1))
	/// abs
	/// acos
	/// asin
	/// atan
	/// ceil
	/// cos
	/// cosh
	/// exp
	/// floor
	/// ln
	/// mag
	/// min
	/// max
	/// norm
	/// dot (only by vtkExprTkFunctionParser)
	/// cross
	/// sign
	/// sin
	/// sinh
	/// sqrt
	/// tan
	/// tanh
	///
	/// Note that some of these operations work on scalars, some on vectors, and some on
	/// both (e.g., you can multiply a scalar times a vector). The operations are performed
	/// tuple-wise (i.e., tuple-by-tuple). The user must specify which arrays to use as
	/// vectors and/or scalars, and the name of the output data array.
	///
	/// </remarks>
	/// <seealso>
	///
	/// For more detailed documentation of the supported functionality see:
	/// 1) vtkFunctionParser
	/// 2) vtkExprTkFunctionParser (default)
	/// </seealso>
	// Token: 0x0200093C RID: 2364
	public class vtkArrayCalculator : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060187D0 RID: 100304 RVA: 0x00224073 File Offset: 0x00222273
		static vtkArrayCalculator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayCalculator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060187D1 RID: 100305 RVA: 0x0022409B File Offset: 0x0022229B
		public vtkArrayCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060187D2 RID: 100306
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187D3 RID: 100307 RVA: 0x002240AC File Offset: 0x002222AC
		public new static vtkArrayCalculator New()
		{
			vtkArrayCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187D4 RID: 100308 RVA: 0x00224100 File Offset: 0x00222300
		public vtkArrayCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayCalculator.vtkArrayCalculator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060187D5 RID: 100309 RVA: 0x00224144 File Offset: 0x00222344
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060187D6 RID: 100310
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_AddCoordinateScalarVariable_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, int component);

		/// <summary>
		/// Add a variable name, a corresponding array name, and which components of
		/// the array to use. The variable name should be sanitized or in quotes.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x060187D7 RID: 100311 RVA: 0x0022414F File Offset: 0x0022234F
		public void AddCoordinateScalarVariable(string variableName, int component)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddCoordinateScalarVariable_01(base.GetCppThis(), variableName, component);
		}

		// Token: 0x060187D8 RID: 100312
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_AddCoordinateVectorVariable_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, int component0, int component1, int component2);

		/// <summary>
		/// Add a variable name, a corresponding array name, and which components of
		/// the array to use. The variable name should be sanitized or in quotes.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x060187D9 RID: 100313 RVA: 0x00224160 File Offset: 0x00222360
		public void AddCoordinateVectorVariable(string variableName, int component0, int component1, int component2)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddCoordinateVectorVariable_02(base.GetCppThis(), variableName, component0, component1, component2);
		}

		// Token: 0x060187DA RID: 100314
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_AddScalarArrayName_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component);

		/// <summary>
		/// Add an array name to the list of arrays used in the function and specify
		/// which components of the array to use in evaluating the function. The
		/// array name must match the name in the function. If the array name is not
		/// sanitized, the variable name will be the array name enclosed in quotes.
		/// Use AddScalarVariable or AddVectorVariable to use a user defined
		/// variable name.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x060187DB RID: 100315 RVA: 0x00224174 File Offset: 0x00222374
		public void AddScalarArrayName(string arrayName, int component)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddScalarArrayName_03(base.GetCppThis(), arrayName, component);
		}

		// Token: 0x060187DC RID: 100316
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_AddScalarVariable_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component);

		/// <summary>
		/// Add a variable name, a corresponding array name, and which components of
		/// the array to use. The variable name should be sanitized or in quotes.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x060187DD RID: 100317 RVA: 0x00224185 File Offset: 0x00222385
		public void AddScalarVariable(string variableName, string arrayName, int component)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddScalarVariable_04(base.GetCppThis(), variableName, arrayName, component);
		}

		// Token: 0x060187DE RID: 100318
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_AddVectorArrayName_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component0, int component1, int component2);

		/// <summary>
		/// Add an array name to the list of arrays used in the function and specify
		/// which components of the array to use in evaluating the function. The
		/// array name must match the name in the function. If the array name is not
		/// sanitized, the variable name will be the array name enclosed in quotes.
		/// Use AddScalarVariable or AddVectorVariable to use a user defined
		/// variable name.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x060187DF RID: 100319 RVA: 0x00224197 File Offset: 0x00222397
		public void AddVectorArrayName(string arrayName, int component0, int component1, int component2)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddVectorArrayName_05(base.GetCppThis(), arrayName, component0, component1, component2);
		}

		// Token: 0x060187E0 RID: 100320
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_AddVectorVariable_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int component0, int component1, int component2);

		/// <summary>
		/// Add a variable name, a corresponding array name, and which components of
		/// the array to use. The variable name should be sanitized or in quotes.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x060187E1 RID: 100321 RVA: 0x002241AB File Offset: 0x002223AB
		public void AddVectorVariable(string variableName, string arrayName, int component0, int component1, int component2)
		{
			vtkArrayCalculator.vtkArrayCalculator_AddVectorVariable_06(base.GetCppThis(), variableName, arrayName, component0, component1, component2);
		}

		// Token: 0x060187E2 RID: 100322
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_CoordinateResultsOff_07(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as coordinates.  ResultArrayName will be
		/// ignored.  Outputting as coordinates is only valid with vector results and
		/// if the AttributeMode is AttributeModeToUsePointData.
		/// If a valid output can't be made, an error will occur.
		/// </summary>
		// Token: 0x060187E3 RID: 100323 RVA: 0x002241C1 File Offset: 0x002223C1
		public virtual void CoordinateResultsOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_CoordinateResultsOff_07(base.GetCppThis());
		}

		// Token: 0x060187E4 RID: 100324
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_CoordinateResultsOn_08(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as coordinates.  ResultArrayName will be
		/// ignored.  Outputting as coordinates is only valid with vector results and
		/// if the AttributeMode is AttributeModeToUsePointData.
		/// If a valid output can't be made, an error will occur.
		/// </summary>
		// Token: 0x060187E5 RID: 100325 RVA: 0x002241D0 File Offset: 0x002223D0
		public virtual void CoordinateResultsOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_CoordinateResultsOn_08(base.GetCppThis());
		}

		// Token: 0x060187E6 RID: 100326
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetAttributeType_09(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x060187E7 RID: 100327 RVA: 0x002241E0 File Offset: 0x002223E0
		public virtual int GetAttributeType()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetAttributeType_09(base.GetCppThis());
		}

		// Token: 0x060187E8 RID: 100328
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_GetAttributeTypeAsString_10(HandleRef pThis);

		/// <summary>
		/// Returns a string representation of the calculator's AttributeType
		/// </summary>
		// Token: 0x060187E9 RID: 100329 RVA: 0x00224200 File Offset: 0x00222400
		public string GetAttributeTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetAttributeTypeAsString_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060187EA RID: 100330
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetCoordinateResults_11(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as coordinates.  ResultArrayName will be
		/// ignored.  Outputting as coordinates is only valid with vector results and
		/// if the AttributeMode is AttributeModeToUsePointData.
		/// If a valid output can't be made, an error will occur.
		/// </summary>
		// Token: 0x060187EB RID: 100331 RVA: 0x0022423C File Offset: 0x0022243C
		public virtual int GetCoordinateResults()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetCoordinateResults_11(base.GetCppThis());
		}

		// Token: 0x060187EC RID: 100332
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_GetDataSetOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the output of the filter downcast to a vtkDataSet or nullptr if the
		/// cast fails.
		/// </summary>
		// Token: 0x060187ED RID: 100333 RVA: 0x0022425C File Offset: 0x0022245C
		public vtkDataSet GetDataSetOutput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_GetDataSetOutput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x060187EE RID: 100334
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_GetFunction_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the function to be evaluated.
		/// </summary>
		// Token: 0x060187EF RID: 100335 RVA: 0x002242CC File Offset: 0x002224CC
		public virtual string GetFunction()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetFunction_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060187F0 RID: 100336
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkArrayCalculator.FunctionParserTypes vtkArrayCalculator_GetFunctionParserType_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the FunctionParser type that will be used.
		/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
		/// </summary>
		// Token: 0x060187F1 RID: 100337 RVA: 0x00224308 File Offset: 0x00222508
		public virtual vtkArrayCalculator.FunctionParserTypes GetFunctionParserType()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetFunctionParserType_14(base.GetCppThis());
		}

		// Token: 0x060187F2 RID: 100338
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayCalculator_GetIgnoreMissingArrays_15(HandleRef pThis);

		/// <summary>
		/// When this option is set, silently ignore datasets where the requested field
		/// data array is not present. When an input array is not present, the result array
		/// will not be generated nor added to the output.
		/// </summary>
		// Token: 0x060187F3 RID: 100339 RVA: 0x00224328 File Offset: 0x00222528
		public virtual bool GetIgnoreMissingArrays()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetIgnoreMissingArrays_15(base.GetCppThis()) != 0;
		}

		// Token: 0x060187F4 RID: 100340
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayCalculator_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187F5 RID: 100341 RVA: 0x00224350 File Offset: 0x00222550
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060187F6 RID: 100342
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayCalculator_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060187F7 RID: 100343 RVA: 0x00224370 File Offset: 0x00222570
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060187F8 RID: 100344
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetNumberOfScalarArrays_18(HandleRef pThis);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x060187F9 RID: 100345 RVA: 0x0022438C File Offset: 0x0022258C
		public int GetNumberOfScalarArrays()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetNumberOfScalarArrays_18(base.GetCppThis());
		}

		// Token: 0x060187FA RID: 100346
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetNumberOfVectorArrays_19(HandleRef pThis);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x060187FB RID: 100347 RVA: 0x002243AC File Offset: 0x002225AC
		public int GetNumberOfVectorArrays()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetNumberOfVectorArrays_19(base.GetCppThis());
		}

		// Token: 0x060187FC RID: 100348
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetReplaceInvalidValues_20(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported.
		/// </summary>
		// Token: 0x060187FD RID: 100349 RVA: 0x002243CC File Offset: 0x002225CC
		public virtual int GetReplaceInvalidValues()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetReplaceInvalidValues_20(base.GetCppThis());
		}

		// Token: 0x060187FE RID: 100350
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArrayCalculator_GetReplacementValue_21(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported.
		/// </summary>
		// Token: 0x060187FF RID: 100351 RVA: 0x002243EC File Offset: 0x002225EC
		public virtual double GetReplacementValue()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetReplacementValue_21(base.GetCppThis());
		}

		// Token: 0x06018800 RID: 100352
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_GetResultArrayName_22(HandleRef pThis);

		/// <summary>
		/// Set the name of the array in which to store the result of
		/// evaluating this function.  If this is the name of an existing array,
		/// that array will be overwritten.  Otherwise a new array will be
		/// created with the specified name.
		/// </summary>
		// Token: 0x06018801 RID: 100353 RVA: 0x0022440C File Offset: 0x0022260C
		public virtual string GetResultArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayCalculator.vtkArrayCalculator_GetResultArrayName_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018802 RID: 100354
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetResultArrayType_23(HandleRef pThis);

		/// <summary>
		/// Type of the result array. It is ignored if CoordinateResults is true.
		/// Initial value is VTK_DOUBLE.
		/// </summary>
		// Token: 0x06018803 RID: 100355 RVA: 0x00224448 File Offset: 0x00222648
		public virtual int GetResultArrayType()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetResultArrayType_23(base.GetCppThis());
		}

		// Token: 0x06018804 RID: 100356
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayCalculator_GetResultNormals_24(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as point/cell normals. Outputting as
		/// normals is only valid with vector results. Point or cell normals are
		/// selected using AttributeMode.
		/// </summary>
		// Token: 0x06018805 RID: 100357 RVA: 0x00224468 File Offset: 0x00222668
		public virtual bool GetResultNormals()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetResultNormals_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06018806 RID: 100358
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayCalculator_GetResultTCoords_25(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as point/cell texture coordinates.
		/// Point or cell texture coordinates are selected using AttributeMode.
		/// 2-component texture coordinates cannot be generated at this time.
		/// </summary>
		// Token: 0x06018807 RID: 100359 RVA: 0x00224490 File Offset: 0x00222690
		public virtual bool GetResultTCoords()
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetResultTCoords_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06018808 RID: 100360
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayCalculator_GetScalarArrayName_26(HandleRef pThis, int i);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x06018809 RID: 100361 RVA: 0x002244B8 File Offset: 0x002226B8
		public string GetScalarArrayName(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetScalarArrayName_26(base.GetCppThis(), i);
		}

		// Token: 0x0601880A RID: 100362
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayCalculator_GetScalarVariableName_27(HandleRef pThis, int i);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x0601880B RID: 100363 RVA: 0x002244D8 File Offset: 0x002226D8
		public string GetScalarVariableName(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetScalarVariableName_27(base.GetCppThis(), i);
		}

		// Token: 0x0601880C RID: 100364
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_GetSelectedScalarComponent_28(HandleRef pThis, int i);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x0601880D RID: 100365 RVA: 0x002244F8 File Offset: 0x002226F8
		public int GetSelectedScalarComponent(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetSelectedScalarComponent_28(base.GetCppThis(), i);
		}

		// Token: 0x0601880E RID: 100366
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayCalculator_GetVectorArrayName_29(HandleRef pThis, int i);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x0601880F RID: 100367 RVA: 0x00224518 File Offset: 0x00222718
		public string GetVectorArrayName(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetVectorArrayName_29(base.GetCppThis(), i);
		}

		// Token: 0x06018810 RID: 100368
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayCalculator_GetVectorVariableName_30(HandleRef pThis, int i);

		/// <summary>
		/// Methods to get information about the current variables.
		/// </summary>
		// Token: 0x06018811 RID: 100369 RVA: 0x00224538 File Offset: 0x00222738
		public string GetVectorVariableName(int i)
		{
			return vtkArrayCalculator.vtkArrayCalculator_GetVectorVariableName_30(base.GetCppThis(), i);
		}

		// Token: 0x06018812 RID: 100370
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_IgnoreMissingArraysOff_31(HandleRef pThis);

		/// <summary>
		/// When this option is set, silently ignore datasets where the requested field
		/// data array is not present. When an input array is not present, the result array
		/// will not be generated nor added to the output.
		/// </summary>
		// Token: 0x06018813 RID: 100371 RVA: 0x00224558 File Offset: 0x00222758
		public virtual void IgnoreMissingArraysOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_IgnoreMissingArraysOff_31(base.GetCppThis());
		}

		// Token: 0x06018814 RID: 100372
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_IgnoreMissingArraysOn_32(HandleRef pThis);

		/// <summary>
		/// When this option is set, silently ignore datasets where the requested field
		/// data array is not present. When an input array is not present, the result array
		/// will not be generated nor added to the output.
		/// </summary>
		// Token: 0x06018815 RID: 100373 RVA: 0x00224567 File Offset: 0x00222767
		public virtual void IgnoreMissingArraysOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_IgnoreMissingArraysOn_32(base.GetCppThis());
		}

		// Token: 0x06018816 RID: 100374
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018817 RID: 100375 RVA: 0x00224578 File Offset: 0x00222778
		public override int IsA(string type)
		{
			return vtkArrayCalculator.vtkArrayCalculator_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x06018818 RID: 100376
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayCalculator_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018819 RID: 100377 RVA: 0x00224598 File Offset: 0x00222798
		public new static int IsTypeOf(string type)
		{
			return vtkArrayCalculator.vtkArrayCalculator_IsTypeOf_34(type);
		}

		// Token: 0x0601881A RID: 100378
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601881B RID: 100379 RVA: 0x002245B4 File Offset: 0x002227B4
		public new vtkArrayCalculator NewInstance()
		{
			vtkArrayCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601881C RID: 100380
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_RemoveAllVariables_37(HandleRef pThis);

		/// <summary>
		/// Remove all the variable names and their associated array names.
		/// </summary>
		// Token: 0x0601881D RID: 100381 RVA: 0x0022460E File Offset: 0x0022280E
		public void RemoveAllVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveAllVariables_37(base.GetCppThis());
		}

		// Token: 0x0601881E RID: 100382
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_RemoveCoordinateScalarVariables_38(HandleRef pThis);

		/// <summary>
		/// Remove all the coordinate variables.
		/// </summary>
		// Token: 0x0601881F RID: 100383 RVA: 0x0022461D File Offset: 0x0022281D
		public virtual void RemoveCoordinateScalarVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveCoordinateScalarVariables_38(base.GetCppThis());
		}

		// Token: 0x06018820 RID: 100384
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_RemoveCoordinateVectorVariables_39(HandleRef pThis);

		/// <summary>
		/// Remove all the coordinate variables.
		/// </summary>
		// Token: 0x06018821 RID: 100385 RVA: 0x0022462C File Offset: 0x0022282C
		public virtual void RemoveCoordinateVectorVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveCoordinateVectorVariables_39(base.GetCppThis());
		}

		// Token: 0x06018822 RID: 100386
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_RemoveScalarVariables_40(HandleRef pThis);

		/// <summary>
		/// Remove all the scalar variable names and their associated array names.
		/// </summary>
		// Token: 0x06018823 RID: 100387 RVA: 0x0022463B File Offset: 0x0022283B
		public virtual void RemoveScalarVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveScalarVariables_40(base.GetCppThis());
		}

		// Token: 0x06018824 RID: 100388
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_RemoveVectorVariables_41(HandleRef pThis);

		/// <summary>
		/// Remove all the scalar variable names and their associated array names.
		/// </summary>
		// Token: 0x06018825 RID: 100389 RVA: 0x0022464A File Offset: 0x0022284A
		public virtual void RemoveVectorVariables()
		{
			vtkArrayCalculator.vtkArrayCalculator_RemoveVectorVariables_41(base.GetCppThis());
		}

		// Token: 0x06018826 RID: 100390
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_ReplaceInvalidValuesOff_42(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported.
		/// </summary>
		// Token: 0x06018827 RID: 100391 RVA: 0x00224659 File Offset: 0x00222859
		public virtual void ReplaceInvalidValuesOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_ReplaceInvalidValuesOff_42(base.GetCppThis());
		}

		// Token: 0x06018828 RID: 100392
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_ReplaceInvalidValuesOn_43(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported.
		/// </summary>
		// Token: 0x06018829 RID: 100393 RVA: 0x00224668 File Offset: 0x00222868
		public virtual void ReplaceInvalidValuesOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_ReplaceInvalidValuesOn_43(base.GetCppThis());
		}

		// Token: 0x0601882A RID: 100394
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_ResultNormalsOff_44(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as point/cell normals. Outputting as
		/// normals is only valid with vector results. Point or cell normals are
		/// selected using AttributeMode.
		/// </summary>
		// Token: 0x0601882B RID: 100395 RVA: 0x00224677 File Offset: 0x00222877
		public virtual void ResultNormalsOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_ResultNormalsOff_44(base.GetCppThis());
		}

		// Token: 0x0601882C RID: 100396
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_ResultNormalsOn_45(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as point/cell normals. Outputting as
		/// normals is only valid with vector results. Point or cell normals are
		/// selected using AttributeMode.
		/// </summary>
		// Token: 0x0601882D RID: 100397 RVA: 0x00224686 File Offset: 0x00222886
		public virtual void ResultNormalsOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_ResultNormalsOn_45(base.GetCppThis());
		}

		// Token: 0x0601882E RID: 100398
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_ResultTCoordsOff_46(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as point/cell texture coordinates.
		/// Point or cell texture coordinates are selected using AttributeMode.
		/// 2-component texture coordinates cannot be generated at this time.
		/// </summary>
		// Token: 0x0601882F RID: 100399 RVA: 0x00224695 File Offset: 0x00222895
		public virtual void ResultTCoordsOff()
		{
			vtkArrayCalculator.vtkArrayCalculator_ResultTCoordsOff_46(base.GetCppThis());
		}

		// Token: 0x06018830 RID: 100400
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_ResultTCoordsOn_47(HandleRef pThis);

		/// <summary>
		/// Set whether to output results as point/cell texture coordinates.
		/// Point or cell texture coordinates are selected using AttributeMode.
		/// 2-component texture coordinates cannot be generated at this time.
		/// </summary>
		// Token: 0x06018831 RID: 100401 RVA: 0x002246A4 File Offset: 0x002228A4
		public virtual void ResultTCoordsOn()
		{
			vtkArrayCalculator.vtkArrayCalculator_ResultTCoordsOn_47(base.GetCppThis());
		}

		// Token: 0x06018832 RID: 100402
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayCalculator_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018833 RID: 100403 RVA: 0x002246B4 File Offset: 0x002228B4
		public new static vtkArrayCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkArrayCalculator vtkArrayCalculator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayCalculator.vtkArrayCalculator_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayCalculator = (vtkArrayCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayCalculator.Register(null);
				}
			}
			return vtkArrayCalculator;
		}

		// Token: 0x06018834 RID: 100404
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeType_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x06018835 RID: 100405 RVA: 0x00224733 File Offset: 0x00222933
		public virtual void SetAttributeType(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeType_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06018836 RID: 100406
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeTypeToCellData_50(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x06018837 RID: 100407 RVA: 0x00224743 File Offset: 0x00222943
		public void SetAttributeTypeToCellData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeTypeToCellData_50(base.GetCppThis());
		}

		// Token: 0x06018838 RID: 100408
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeTypeToDefault_51(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x06018839 RID: 100409 RVA: 0x00224752 File Offset: 0x00222952
		public void SetAttributeTypeToDefault()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeTypeToDefault_51(base.GetCppThis());
		}

		// Token: 0x0601883A RID: 100410
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeTypeToEdgeData_52(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x0601883B RID: 100411 RVA: 0x00224761 File Offset: 0x00222961
		public void SetAttributeTypeToEdgeData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeTypeToEdgeData_52(base.GetCppThis());
		}

		// Token: 0x0601883C RID: 100412
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeTypeToPointData_53(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x0601883D RID: 100413 RVA: 0x00224770 File Offset: 0x00222970
		public void SetAttributeTypeToPointData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeTypeToPointData_53(base.GetCppThis());
		}

		// Token: 0x0601883E RID: 100414
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeTypeToRowData_54(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x0601883F RID: 100415 RVA: 0x0022477F File Offset: 0x0022297F
		public void SetAttributeTypeToRowData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeTypeToRowData_54(base.GetCppThis());
		}

		// Token: 0x06018840 RID: 100416
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetAttributeTypeToVertexData_55(HandleRef pThis);

		/// <summary>
		/// Control which AttributeType the filter operates on (point data or cell data
		/// for vtkDataSets).  By default the filter uses Point/Vertex/Row data depending
		/// on the input data type.  The input value for this function should be one of the
		/// constants in vtkDataObject::AttributeTypes or DEFAULT_ATTRIBUTE_TYPE for 'default behavior'.
		/// </summary>
		// Token: 0x06018841 RID: 100417 RVA: 0x0022478E File Offset: 0x0022298E
		public void SetAttributeTypeToVertexData()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetAttributeTypeToVertexData_55(base.GetCppThis());
		}

		// Token: 0x06018842 RID: 100418
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetCoordinateResults_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to output results as coordinates.  ResultArrayName will be
		/// ignored.  Outputting as coordinates is only valid with vector results and
		/// if the AttributeMode is AttributeModeToUsePointData.
		/// If a valid output can't be made, an error will occur.
		/// </summary>
		// Token: 0x06018843 RID: 100419 RVA: 0x0022479D File Offset: 0x0022299D
		public virtual void SetCoordinateResults(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetCoordinateResults_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06018844 RID: 100420
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetFunction_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the function to be evaluated.
		/// </summary>
		// Token: 0x06018845 RID: 100421 RVA: 0x002247AD File Offset: 0x002229AD
		public virtual void SetFunction(string _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetFunction_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06018846 RID: 100422
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetFunctionParserType_58(HandleRef pThis, vtkArrayCalculator.FunctionParserTypes _arg);

		/// <summary>
		/// Set/Get the FunctionParser type that will be used.
		/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
		/// </summary>
		// Token: 0x06018847 RID: 100423 RVA: 0x002247BD File Offset: 0x002229BD
		public virtual void SetFunctionParserType(vtkArrayCalculator.FunctionParserTypes _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetFunctionParserType_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06018848 RID: 100424
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetFunctionParserTypeToExprTkFunctionParser_59(HandleRef pThis);

		/// <summary>
		/// Set/Get the FunctionParser type that will be used.
		/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
		/// </summary>
		// Token: 0x06018849 RID: 100425 RVA: 0x002247CD File Offset: 0x002229CD
		public void SetFunctionParserTypeToExprTkFunctionParser()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetFunctionParserTypeToExprTkFunctionParser_59(base.GetCppThis());
		}

		// Token: 0x0601884A RID: 100426
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetFunctionParserTypeToFunctionParser_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the FunctionParser type that will be used.
		/// vtkFunctionParser = 0, vtkExprTkFunctionParser = 1. Default is 1.
		/// </summary>
		// Token: 0x0601884B RID: 100427 RVA: 0x002247DC File Offset: 0x002229DC
		public void SetFunctionParserTypeToFunctionParser()
		{
			vtkArrayCalculator.vtkArrayCalculator_SetFunctionParserTypeToFunctionParser_60(base.GetCppThis());
		}

		// Token: 0x0601884C RID: 100428
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetIgnoreMissingArrays_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// When this option is set, silently ignore datasets where the requested field
		/// data array is not present. When an input array is not present, the result array
		/// will not be generated nor added to the output.
		/// </summary>
		// Token: 0x0601884D RID: 100429 RVA: 0x002247EB File Offset: 0x002229EB
		public virtual void SetIgnoreMissingArrays(bool _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetIgnoreMissingArrays_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601884E RID: 100430
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetReplaceInvalidValues_62(HandleRef pThis, int _arg);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported.
		/// </summary>
		// Token: 0x0601884F RID: 100431 RVA: 0x00224803 File Offset: 0x00222A03
		public virtual void SetReplaceInvalidValues(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetReplaceInvalidValues_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06018850 RID: 100432
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetReplacementValue_63(HandleRef pThis, double _arg);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported.
		/// </summary>
		// Token: 0x06018851 RID: 100433 RVA: 0x00224813 File Offset: 0x00222A13
		public virtual void SetReplacementValue(double _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetReplacementValue_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06018852 RID: 100434
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetResultArrayName_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the array in which to store the result of
		/// evaluating this function.  If this is the name of an existing array,
		/// that array will be overwritten.  Otherwise a new array will be
		/// created with the specified name.
		/// </summary>
		// Token: 0x06018853 RID: 100435 RVA: 0x00224823 File Offset: 0x00222A23
		public virtual void SetResultArrayName(string _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetResultArrayName_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06018854 RID: 100436
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetResultArrayType_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Type of the result array. It is ignored if CoordinateResults is true.
		/// Initial value is VTK_DOUBLE.
		/// </summary>
		// Token: 0x06018855 RID: 100437 RVA: 0x00224833 File Offset: 0x00222A33
		public virtual void SetResultArrayType(int _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetResultArrayType_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06018856 RID: 100438
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetResultNormals_66(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to output results as point/cell normals. Outputting as
		/// normals is only valid with vector results. Point or cell normals are
		/// selected using AttributeMode.
		/// </summary>
		// Token: 0x06018857 RID: 100439 RVA: 0x00224843 File Offset: 0x00222A43
		public virtual void SetResultNormals(bool _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetResultNormals_66(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018858 RID: 100440
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayCalculator_SetResultTCoords_67(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to output results as point/cell texture coordinates.
		/// Point or cell texture coordinates are selected using AttributeMode.
		/// 2-component texture coordinates cannot be generated at this time.
		/// </summary>
		// Token: 0x06018859 RID: 100441 RVA: 0x0022485B File Offset: 0x00222A5B
		public virtual void SetResultTCoords(bool _arg)
		{
			vtkArrayCalculator.vtkArrayCalculator_SetResultTCoords_67(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B22 RID: 6946
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayCalculator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B23 RID: 6947
		public new static readonly string MRClassNameKey = "class vtkArrayCalculator";

		/// <summary>
		/// Enum that includes the types of parsers that can be used.
		/// </summary>
		// Token: 0x0200093D RID: 2365
		public enum FunctionParserTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001B25 RID: 6949
			ExprTkFunctionParser = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001B26 RID: 6950
			FunctionParser = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001B27 RID: 6951
			NumberOfFunctionParserTypes = 2
		}
	}
}
