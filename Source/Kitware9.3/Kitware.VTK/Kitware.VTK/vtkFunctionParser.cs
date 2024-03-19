using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFunctionParser
	/// </summary>
	/// <remarks>
	///    Parse and evaluate a mathematical expression
	///
	/// vtkFunctionParser is a class that takes in a mathematical expression as
	/// a char string, parses it, and evaluates it at the specified values of
	/// the variables in the input string.
	///
	/// You can use the "if" operator to create conditional expressions
	/// such as if ( test, trueresult, falseresult). These evaluate the boolean
	/// valued test expression and then evaluate either the trueresult or the
	/// falseresult expression to produce a final (scalar or vector valued) value.
	/// "test" may contain &lt;,&gt;,=,|,&amp;, and () and all three subexpressions can
	/// evaluate arbitrary function operators (ln, cos, +, if, etc)
	///
	/// @par Thanks:
	/// Juha Nieminen (juha.nieminen@gmail.com) for relicensing this branch of the
	/// function parser code that this class is based upon under the new BSD license
	/// so that it could be used in VTK. Note, the BSD license applies to this
	/// version of the function parser only (by permission of the author), and not
	/// the original library.
	///
	/// @par Thanks:
	/// Thomas Dunne (thomas.dunne@iwr.uni-heidelberg.de) for adding code for
	/// two-parameter-parsing and a few functions (sign, min, max).
	///
	/// @par Thanks:
	/// Sid Sydoriak (sxs@lanl.gov) for adding boolean operations and
	/// conditional expressions and for fixing a variety of bugs.
	/// </remarks>
	// Token: 0x02000B02 RID: 2818
	public class vtkFunctionParser : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D9AC RID: 121260 RVA: 0x0029CE12 File Offset: 0x0029B012
		static vtkFunctionParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFunctionParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFunctionParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D9AD RID: 121261 RVA: 0x0029CE3A File Offset: 0x0029B03A
		public vtkFunctionParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D9AE RID: 121262
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9AF RID: 121263 RVA: 0x0029CE48 File Offset: 0x0029B048
		public new static vtkFunctionParser New()
		{
			vtkFunctionParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9B0 RID: 121264 RVA: 0x0029CE9C File Offset: 0x0029B09C
		public vtkFunctionParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFunctionParser.vtkFunctionParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D9B1 RID: 121265 RVA: 0x0029CEE0 File Offset: 0x0029B0E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D9B2 RID: 121266
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_GetFunction_01(HandleRef pThis);

		/// <summary>
		/// Set/Get input string to evaluate.
		/// </summary>
		// Token: 0x0601D9B3 RID: 121267 RVA: 0x0029CEEC File Offset: 0x0029B0EC
		public virtual string GetFunction()
		{
			string s = Marshal.PtrToStringAnsi(vtkFunctionParser.vtkFunctionParser_GetFunction_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D9B4 RID: 121268
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFunctionParser_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Return parser's MTime
		/// </summary>
		// Token: 0x0601D9B5 RID: 121269 RVA: 0x0029CF28 File Offset: 0x0029B128
		public override ulong GetMTime()
		{
			return vtkFunctionParser.vtkFunctionParser_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0601D9B6 RID: 121270
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFunctionParser_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9B7 RID: 121271 RVA: 0x0029CF48 File Offset: 0x0029B148
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFunctionParser.vtkFunctionParser_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D9B8 RID: 121272
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFunctionParser_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9B9 RID: 121273 RVA: 0x0029CF68 File Offset: 0x0029B168
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFunctionParser.vtkFunctionParser_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D9BA RID: 121274
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_GetNumberOfScalarVariables_05(HandleRef pThis);

		/// <summary>
		/// Get the number of scalar variables.
		/// </summary>
		// Token: 0x0601D9BB RID: 121275 RVA: 0x0029CF84 File Offset: 0x0029B184
		public int GetNumberOfScalarVariables()
		{
			return vtkFunctionParser.vtkFunctionParser_GetNumberOfScalarVariables_05(base.GetCppThis());
		}

		// Token: 0x0601D9BC RID: 121276
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_GetNumberOfVectorVariables_06(HandleRef pThis);

		/// <summary>
		/// Get the number of vector variables.
		/// </summary>
		// Token: 0x0601D9BD RID: 121277 RVA: 0x0029CFA4 File Offset: 0x0029B1A4
		public int GetNumberOfVectorVariables()
		{
			return vtkFunctionParser.vtkFunctionParser_GetNumberOfVectorVariables_06(base.GetCppThis());
		}

		// Token: 0x0601D9BE RID: 121278
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_GetReplaceInvalidValues_07(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D9BF RID: 121279 RVA: 0x0029CFC4 File Offset: 0x0029B1C4
		public virtual int GetReplaceInvalidValues()
		{
			return vtkFunctionParser.vtkFunctionParser_GetReplaceInvalidValues_07(base.GetCppThis());
		}

		// Token: 0x0601D9C0 RID: 121280
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFunctionParser_GetReplacementValue_08(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D9C1 RID: 121281 RVA: 0x0029CFE4 File Offset: 0x0029B1E4
		public virtual double GetReplacementValue()
		{
			return vtkFunctionParser.vtkFunctionParser_GetReplacementValue_08(base.GetCppThis());
		}

		// Token: 0x0601D9C2 RID: 121282
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFunctionParser_GetScalarResult_09(HandleRef pThis);

		/// <summary>
		/// Get a scalar result from evaluating the input function.
		/// </summary>
		// Token: 0x0601D9C3 RID: 121283 RVA: 0x0029D004 File Offset: 0x0029B204
		public double GetScalarResult()
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarResult_09(base.GetCppThis());
		}

		// Token: 0x0601D9C4 RID: 121284
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_GetScalarVariableIndex_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get scalar variable index or -1 if not found
		/// </summary>
		// Token: 0x0601D9C5 RID: 121285 RVA: 0x0029D024 File Offset: 0x0029B224
		public int GetScalarVariableIndex(string name)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableIndex_10(base.GetCppThis(), name);
		}

		// Token: 0x0601D9C6 RID: 121286
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_GetScalarVariableName_11(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith scalar variable name.
		/// </summary>
		// Token: 0x0601D9C7 RID: 121287 RVA: 0x0029D044 File Offset: 0x0029B244
		public string GetScalarVariableName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkFunctionParser.vtkFunctionParser_GetScalarVariableName_11(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D9C8 RID: 121288
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFunctionParser_GetScalarVariableNeeded_12(HandleRef pThis, int i);

		/// <summary>
		/// Returns whether a scalar variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
		/// or IsScalarResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D9C9 RID: 121289 RVA: 0x0029D080 File Offset: 0x0029B280
		public bool GetScalarVariableNeeded(int i)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableNeeded_12(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0601D9CA RID: 121290
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFunctionParser_GetScalarVariableNeeded_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Returns whether a scalar variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
		/// or IsScalarResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D9CB RID: 121291 RVA: 0x0029D0A8 File Offset: 0x0029B2A8
		public bool GetScalarVariableNeeded(string variableName)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableNeeded_13(base.GetCppThis(), variableName) != 0;
		}

		// Token: 0x0601D9CC RID: 121292
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFunctionParser_GetScalarVariableValue_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Get the value of a scalar variable.
		/// </summary>
		// Token: 0x0601D9CD RID: 121293 RVA: 0x0029D0D0 File Offset: 0x0029B2D0
		public double GetScalarVariableValue(string variableName)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableValue_14(base.GetCppThis(), variableName);
		}

		// Token: 0x0601D9CE RID: 121294
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFunctionParser_GetScalarVariableValue_15(HandleRef pThis, int i);

		/// <summary>
		/// Get the value of a scalar variable.
		/// </summary>
		// Token: 0x0601D9CF RID: 121295 RVA: 0x0029D0F0 File Offset: 0x0029B2F0
		public double GetScalarVariableValue(int i)
		{
			return vtkFunctionParser.vtkFunctionParser_GetScalarVariableValue_15(base.GetCppThis(), i);
		}

		// Token: 0x0601D9D0 RID: 121296
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_GetVectorResult_16(HandleRef pThis);

		/// <summary>
		/// Get a vector result from evaluating the input function.
		/// </summary>
		// Token: 0x0601D9D1 RID: 121297 RVA: 0x0029D110 File Offset: 0x0029B310
		public double[] GetVectorResult()
		{
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_GetVectorResult_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D9D2 RID: 121298
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_GetVectorResult_17(HandleRef pThis, IntPtr result);

		/// <summary>
		/// Get a vector result from evaluating the input function.
		/// </summary>
		// Token: 0x0601D9D3 RID: 121299 RVA: 0x0029D158 File Offset: 0x0029B358
		public void GetVectorResult(IntPtr result)
		{
			vtkFunctionParser.vtkFunctionParser_GetVectorResult_17(base.GetCppThis(), result);
		}

		// Token: 0x0601D9D4 RID: 121300
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_GetVectorVariableIndex_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get scalar variable index or -1 if not found
		/// </summary>
		// Token: 0x0601D9D5 RID: 121301 RVA: 0x0029D168 File Offset: 0x0029B368
		public int GetVectorVariableIndex(string name)
		{
			return vtkFunctionParser.vtkFunctionParser_GetVectorVariableIndex_18(base.GetCppThis(), name);
		}

		// Token: 0x0601D9D6 RID: 121302
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_GetVectorVariableName_19(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith vector variable name.
		/// </summary>
		// Token: 0x0601D9D7 RID: 121303 RVA: 0x0029D188 File Offset: 0x0029B388
		public string GetVectorVariableName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkFunctionParser.vtkFunctionParser_GetVectorVariableName_19(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D9D8 RID: 121304
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFunctionParser_GetVectorVariableNeeded_20(HandleRef pThis, int i);

		/// <summary>
		/// Returns whether a vector variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
		/// or IsVectorResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D9D9 RID: 121305 RVA: 0x0029D1C4 File Offset: 0x0029B3C4
		public bool GetVectorVariableNeeded(int i)
		{
			return vtkFunctionParser.vtkFunctionParser_GetVectorVariableNeeded_20(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0601D9DA RID: 121306
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFunctionParser_GetVectorVariableNeeded_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Returns whether a vector variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
		/// or IsVectorResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D9DB RID: 121307 RVA: 0x0029D1EC File Offset: 0x0029B3EC
		public bool GetVectorVariableNeeded(string variableName)
		{
			return vtkFunctionParser.vtkFunctionParser_GetVectorVariableNeeded_21(base.GetCppThis(), variableName) != 0;
		}

		// Token: 0x0601D9DC RID: 121308
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_GetVectorVariableValue_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D9DD RID: 121309 RVA: 0x0029D214 File Offset: 0x0029B414
		public double[] GetVectorVariableValue(string variableName)
		{
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_22(base.GetCppThis(), variableName);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D9DE RID: 121310
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_GetVectorVariableValue_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, IntPtr value);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D9DF RID: 121311 RVA: 0x0029D25D File Offset: 0x0029B45D
		public void GetVectorVariableValue(string variableName, IntPtr value)
		{
			vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_23(base.GetCppThis(), variableName, value);
		}

		// Token: 0x0601D9E0 RID: 121312
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_GetVectorVariableValue_24(HandleRef pThis, int i);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D9E1 RID: 121313 RVA: 0x0029D270 File Offset: 0x0029B470
		public double[] GetVectorVariableValue(int i)
		{
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_24(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D9E2 RID: 121314
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_GetVectorVariableValue_25(HandleRef pThis, int i, IntPtr value);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D9E3 RID: 121315 RVA: 0x0029D2B9 File Offset: 0x0029B4B9
		public void GetVectorVariableValue(int i, IntPtr value)
		{
			vtkFunctionParser.vtkFunctionParser_GetVectorVariableValue_25(base.GetCppThis(), i, value);
		}

		// Token: 0x0601D9E4 RID: 121316
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_InvalidateFunction_26(HandleRef pThis);

		/// <summary>
		/// Allow the user to force the function to be re-parsed
		/// </summary>
		// Token: 0x0601D9E5 RID: 121317 RVA: 0x0029D2CA File Offset: 0x0029B4CA
		public void InvalidateFunction()
		{
			vtkFunctionParser.vtkFunctionParser_InvalidateFunction_26(base.GetCppThis());
		}

		// Token: 0x0601D9E6 RID: 121318
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9E7 RID: 121319 RVA: 0x0029D2DC File Offset: 0x0029B4DC
		public override int IsA(string type)
		{
			return vtkFunctionParser.vtkFunctionParser_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0601D9E8 RID: 121320
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_IsScalarResult_28(HandleRef pThis);

		/// <summary>
		/// Check whether the result is a scalar result.  If it isn't, then
		/// either the result is a vector or an error has occurred.
		/// </summary>
		// Token: 0x0601D9E9 RID: 121321 RVA: 0x0029D2FC File Offset: 0x0029B4FC
		public int IsScalarResult()
		{
			return vtkFunctionParser.vtkFunctionParser_IsScalarResult_28(base.GetCppThis());
		}

		// Token: 0x0601D9EA RID: 121322
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9EB RID: 121323 RVA: 0x0029D31C File Offset: 0x0029B51C
		public new static int IsTypeOf(string type)
		{
			return vtkFunctionParser.vtkFunctionParser_IsTypeOf_29(type);
		}

		// Token: 0x0601D9EC RID: 121324
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionParser_IsVectorResult_30(HandleRef pThis);

		/// <summary>
		/// Check whether the result is a vector result.  If it isn't, then
		/// either the result is scalar or an error has occurred.
		/// </summary>
		// Token: 0x0601D9ED RID: 121325 RVA: 0x0029D338 File Offset: 0x0029B538
		public int IsVectorResult()
		{
			return vtkFunctionParser.vtkFunctionParser_IsVectorResult_30(base.GetCppThis());
		}

		// Token: 0x0601D9EE RID: 121326
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9EF RID: 121327 RVA: 0x0029D358 File Offset: 0x0029B558
		public new vtkFunctionParser NewInstance()
		{
			vtkFunctionParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D9F0 RID: 121328
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_RemoveAllVariables_33(HandleRef pThis);

		/// <summary>
		/// Remove all the current variables.
		/// </summary>
		// Token: 0x0601D9F1 RID: 121329 RVA: 0x0029D3B2 File Offset: 0x0029B5B2
		public void RemoveAllVariables()
		{
			vtkFunctionParser.vtkFunctionParser_RemoveAllVariables_33(base.GetCppThis());
		}

		// Token: 0x0601D9F2 RID: 121330
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_RemoveScalarVariables_34(HandleRef pThis);

		/// <summary>
		/// Remove all the scalar variables.
		/// </summary>
		// Token: 0x0601D9F3 RID: 121331 RVA: 0x0029D3C1 File Offset: 0x0029B5C1
		public void RemoveScalarVariables()
		{
			vtkFunctionParser.vtkFunctionParser_RemoveScalarVariables_34(base.GetCppThis());
		}

		// Token: 0x0601D9F4 RID: 121332
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_RemoveVectorVariables_35(HandleRef pThis);

		/// <summary>
		/// Remove all the vector variables.
		/// </summary>
		// Token: 0x0601D9F5 RID: 121333 RVA: 0x0029D3D0 File Offset: 0x0029B5D0
		public void RemoveVectorVariables()
		{
			vtkFunctionParser.vtkFunctionParser_RemoveVectorVariables_35(base.GetCppThis());
		}

		// Token: 0x0601D9F6 RID: 121334
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_ReplaceInvalidValuesOff_36(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D9F7 RID: 121335 RVA: 0x0029D3DF File Offset: 0x0029B5DF
		public virtual void ReplaceInvalidValuesOff()
		{
			vtkFunctionParser.vtkFunctionParser_ReplaceInvalidValuesOff_36(base.GetCppThis());
		}

		// Token: 0x0601D9F8 RID: 121336
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_ReplaceInvalidValuesOn_37(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D9F9 RID: 121337 RVA: 0x0029D3EE File Offset: 0x0029B5EE
		public virtual void ReplaceInvalidValuesOn()
		{
			vtkFunctionParser.vtkFunctionParser_ReplaceInvalidValuesOn_37(base.GetCppThis());
		}

		// Token: 0x0601D9FA RID: 121338
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionParser_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D9FB RID: 121339 RVA: 0x0029D400 File Offset: 0x0029B600
		public new static vtkFunctionParser SafeDownCast(vtkObjectBase o)
		{
			vtkFunctionParser vtkFunctionParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFunctionParser.vtkFunctionParser_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionParser = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionParser.Register(null);
				}
			}
			return vtkFunctionParser;
		}

		// Token: 0x0601D9FC RID: 121340
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetFunction_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string function);

		/// <summary>
		/// Set/Get input string to evaluate.
		/// </summary>
		// Token: 0x0601D9FD RID: 121341 RVA: 0x0029D47F File Offset: 0x0029B67F
		public void SetFunction(string function)
		{
			vtkFunctionParser.vtkFunctionParser_SetFunction_39(base.GetCppThis(), function);
		}

		// Token: 0x0601D9FE RID: 121342
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetReplaceInvalidValues_40(HandleRef pThis, int _arg);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D9FF RID: 121343 RVA: 0x0029D48F File Offset: 0x0029B68F
		public virtual void SetReplaceInvalidValues(int _arg)
		{
			vtkFunctionParser.vtkFunctionParser_SetReplaceInvalidValues_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DA00 RID: 121344
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetReplacementValue_41(HandleRef pThis, double _arg);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601DA01 RID: 121345 RVA: 0x0029D49F File Offset: 0x0029B69F
		public virtual void SetReplacementValue(double _arg)
		{
			vtkFunctionParser.vtkFunctionParser_SetReplacementValue_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DA02 RID: 121346
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetScalarVariableValue_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, double value);

		/// <summary>
		/// Set the value of a scalar variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value.
		/// </summary>
		// Token: 0x0601DA03 RID: 121347 RVA: 0x0029D4AF File Offset: 0x0029B6AF
		public void SetScalarVariableValue(string variableName, double value)
		{
			vtkFunctionParser.vtkFunctionParser_SetScalarVariableValue_42(base.GetCppThis(), variableName, value);
		}

		// Token: 0x0601DA04 RID: 121348
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetScalarVariableValue_43(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set the value of a scalar variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value.
		/// </summary>
		// Token: 0x0601DA05 RID: 121349 RVA: 0x0029D4C0 File Offset: 0x0029B6C0
		public void SetScalarVariableValue(int i, double value)
		{
			vtkFunctionParser.vtkFunctionParser_SetScalarVariableValue_43(base.GetCppThis(), i, value);
		}

		// Token: 0x0601DA06 RID: 121350
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, double xValue, double yValue, double zValue);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value.
		/// </summary>
		// Token: 0x0601DA07 RID: 121351 RVA: 0x0029D4D1 File Offset: 0x0029B6D1
		public void SetVectorVariableValue(string variableName, double xValue, double yValue, double zValue)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_44(base.GetCppThis(), variableName, xValue, yValue, zValue);
		}

		// Token: 0x0601DA08 RID: 121352
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, IntPtr values);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value.
		/// </summary>
		// Token: 0x0601DA09 RID: 121353 RVA: 0x0029D4E5 File Offset: 0x0029B6E5
		public void SetVectorVariableValue(string variableName, IntPtr values)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_45(base.GetCppThis(), variableName, values);
		}

		// Token: 0x0601DA0A RID: 121354
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_46(HandleRef pThis, int i, double xValue, double yValue, double zValue);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value.
		/// </summary>
		// Token: 0x0601DA0B RID: 121355 RVA: 0x0029D4F6 File Offset: 0x0029B6F6
		public void SetVectorVariableValue(int i, double xValue, double yValue, double zValue)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_46(base.GetCppThis(), i, xValue, yValue, zValue);
		}

		// Token: 0x0601DA0C RID: 121356
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFunctionParser_SetVectorVariableValue_47(HandleRef pThis, int i, IntPtr values);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value.
		/// </summary>
		// Token: 0x0601DA0D RID: 121357 RVA: 0x0029D50A File Offset: 0x0029B70A
		public void SetVectorVariableValue(int i, IntPtr values)
		{
			vtkFunctionParser.vtkFunctionParser_SetVectorVariableValue_47(base.GetCppThis(), i, values);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F35 RID: 7989
		public new const string MRFullTypeName = "Kitware.VTK.vtkFunctionParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F36 RID: 7990
		public new static readonly string MRClassNameKey = "class vtkFunctionParser";
	}
}
