using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExprTkFunctionParser
	/// </summary>
	/// <remarks>
	///    Parse and evaluate a mathematical expression
	///
	/// vtkExprTkFunctionParser is a wrapper class of the ExprTK library that takes
	/// in a mathematical expression as a char string, parses it, and evaluates it
	/// at the specified values of the variables in the input string.
	///
	/// The detailed documentation of the supported functionality is described in
	/// https://github.com/ArashPartow/exprtk. In addition to the documented
	/// functionality, the following vector operations have been implemented:
	/// 1) cross(v1, v2), cross product of two vectors,
	/// 2) mag(v), magnitude of a vector,
	/// 3) norm(v), the normalized version of a vector.
	///
	/// @par Thanks:
	/// Arash Partow for implementing the ExprTk library.
	/// </remarks>
	// Token: 0x02000B01 RID: 2817
	public class vtkExprTkFunctionParser : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D948 RID: 121160 RVA: 0x0029C7A1 File Offset: 0x0029A9A1
		static vtkExprTkFunctionParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExprTkFunctionParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExprTkFunctionParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D949 RID: 121161 RVA: 0x0029C7C9 File Offset: 0x0029A9C9
		public vtkExprTkFunctionParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D94A RID: 121162
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D94B RID: 121163 RVA: 0x0029C7D8 File Offset: 0x0029A9D8
		public new static vtkExprTkFunctionParser New()
		{
			vtkExprTkFunctionParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExprTkFunctionParser.vtkExprTkFunctionParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExprTkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D94C RID: 121164 RVA: 0x0029C82C File Offset: 0x0029AA2C
		public vtkExprTkFunctionParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExprTkFunctionParser.vtkExprTkFunctionParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D94D RID: 121165 RVA: 0x0029C870 File Offset: 0x0029AA70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D94E RID: 121166
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_GetFunction_01(HandleRef pThis);

		/// <summary>
		/// Set/Get input string to evaluate.
		/// </summary>
		// Token: 0x0601D94F RID: 121167 RVA: 0x0029C87C File Offset: 0x0029AA7C
		public string GetFunction()
		{
			string s = Marshal.PtrToStringAnsi(vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetFunction_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D950 RID: 121168
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExprTkFunctionParser_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Return parser's MTime
		/// </summary>
		// Token: 0x0601D951 RID: 121169 RVA: 0x0029C8B8 File Offset: 0x0029AAB8
		public override ulong GetMTime()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0601D952 RID: 121170
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExprTkFunctionParser_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D953 RID: 121171 RVA: 0x0029C8D8 File Offset: 0x0029AAD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D954 RID: 121172
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExprTkFunctionParser_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D955 RID: 121173 RVA: 0x0029C8F8 File Offset: 0x0029AAF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D956 RID: 121174
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_GetNumberOfScalarVariables_05(HandleRef pThis);

		/// <summary>
		/// Get the number of scalar variables.
		/// </summary>
		// Token: 0x0601D957 RID: 121175 RVA: 0x0029C914 File Offset: 0x0029AB14
		public int GetNumberOfScalarVariables()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetNumberOfScalarVariables_05(base.GetCppThis());
		}

		// Token: 0x0601D958 RID: 121176
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_GetNumberOfVectorVariables_06(HandleRef pThis);

		/// <summary>
		/// Get the number of vector variables.
		/// </summary>
		// Token: 0x0601D959 RID: 121177 RVA: 0x0029C934 File Offset: 0x0029AB34
		public int GetNumberOfVectorVariables()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetNumberOfVectorVariables_06(base.GetCppThis());
		}

		// Token: 0x0601D95A RID: 121178
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_GetReplaceInvalidValues_07(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D95B RID: 121179 RVA: 0x0029C954 File Offset: 0x0029AB54
		public virtual int GetReplaceInvalidValues()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetReplaceInvalidValues_07(base.GetCppThis());
		}

		// Token: 0x0601D95C RID: 121180
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExprTkFunctionParser_GetReplacementValue_08(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D95D RID: 121181 RVA: 0x0029C974 File Offset: 0x0029AB74
		public virtual double GetReplacementValue()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetReplacementValue_08(base.GetCppThis());
		}

		// Token: 0x0601D95E RID: 121182
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExprTkFunctionParser_GetScalarResult_09(HandleRef pThis);

		/// <summary>
		/// Get a scalar result from evaluating the input function.
		///
		/// If ReplaceInvalidValues is not set, then the error value
		/// that will be return is NaN.
		/// </summary>
		// Token: 0x0601D95F RID: 121183 RVA: 0x0029C994 File Offset: 0x0029AB94
		public double GetScalarResult()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarResult_09(base.GetCppThis());
		}

		// Token: 0x0601D960 RID: 121184
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_GetScalarVariableIndex_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get scalar variable index or -1 if not found
		/// </summary>
		// Token: 0x0601D961 RID: 121185 RVA: 0x0029C9B4 File Offset: 0x0029ABB4
		public int GetScalarVariableIndex(string name)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarVariableIndex_10(base.GetCppThis(), name);
		}

		// Token: 0x0601D962 RID: 121186
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkExprTkFunctionParser_GetScalarVariableName_11(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith scalar variable name.
		/// </summary>
		// Token: 0x0601D963 RID: 121187 RVA: 0x0029C9D4 File Offset: 0x0029ABD4
		public string GetScalarVariableName(int i)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarVariableName_11(base.GetCppThis(), i);
		}

		// Token: 0x0601D964 RID: 121188
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExprTkFunctionParser_GetScalarVariableNeeded_12(HandleRef pThis, int i);

		/// <summary>
		/// Returns whether a scalar variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
		/// or IsScalarResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D965 RID: 121189 RVA: 0x0029C9F4 File Offset: 0x0029ABF4
		public bool GetScalarVariableNeeded(int i)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarVariableNeeded_12(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0601D966 RID: 121190
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExprTkFunctionParser_GetScalarVariableNeeded_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Returns whether a scalar variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetScalarResult()
		/// or IsScalarResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D967 RID: 121191 RVA: 0x0029CA1C File Offset: 0x0029AC1C
		public bool GetScalarVariableNeeded(string variableName)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarVariableNeeded_13(base.GetCppThis(), variableName) != 0;
		}

		// Token: 0x0601D968 RID: 121192
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExprTkFunctionParser_GetScalarVariableValue_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Get the value of a scalar variable.
		/// </summary>
		// Token: 0x0601D969 RID: 121193 RVA: 0x0029CA44 File Offset: 0x0029AC44
		public double GetScalarVariableValue(string variableName)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarVariableValue_14(base.GetCppThis(), variableName);
		}

		// Token: 0x0601D96A RID: 121194
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExprTkFunctionParser_GetScalarVariableValue_15(HandleRef pThis, int i);

		/// <summary>
		/// Get the value of a scalar variable.
		/// </summary>
		// Token: 0x0601D96B RID: 121195 RVA: 0x0029CA64 File Offset: 0x0029AC64
		public double GetScalarVariableValue(int i)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetScalarVariableValue_15(base.GetCppThis(), i);
		}

		// Token: 0x0601D96C RID: 121196
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_GetVectorResult_16(HandleRef pThis);

		/// <summary>
		/// Get a vector result from evaluating the input function.
		///
		/// If ReplaceInvalidValues is not set, then the error value
		/// that will be return is [NaN, NaN, NaN].
		/// </summary>
		// Token: 0x0601D96D RID: 121197 RVA: 0x0029CA84 File Offset: 0x0029AC84
		public IntPtr GetVectorResult()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorResult_16(base.GetCppThis());
		}

		// Token: 0x0601D96E RID: 121198
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_GetVectorResult_17(HandleRef pThis, IntPtr result);

		/// <summary>
		/// Get a vector result from evaluating the input function.
		///
		/// If ReplaceInvalidValues is not set, then the error value
		/// that will be return is [NaN, NaN, NaN].
		/// </summary>
		// Token: 0x0601D96F RID: 121199 RVA: 0x0029CAA3 File Offset: 0x0029ACA3
		public void GetVectorResult(IntPtr result)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorResult_17(base.GetCppThis(), result);
		}

		// Token: 0x0601D970 RID: 121200
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_GetVectorVariableIndex_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get scalar variable index or -1 if not found
		/// </summary>
		// Token: 0x0601D971 RID: 121201 RVA: 0x0029CAB4 File Offset: 0x0029ACB4
		public int GetVectorVariableIndex(string name)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableIndex_18(base.GetCppThis(), name);
		}

		// Token: 0x0601D972 RID: 121202
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkExprTkFunctionParser_GetVectorVariableName_19(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith vector variable name.
		/// </summary>
		// Token: 0x0601D973 RID: 121203 RVA: 0x0029CAD4 File Offset: 0x0029ACD4
		public string GetVectorVariableName(int i)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableName_19(base.GetCppThis(), i);
		}

		// Token: 0x0601D974 RID: 121204
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExprTkFunctionParser_GetVectorVariableNeeded_20(HandleRef pThis, int i);

		/// <summary>
		/// Returns whether a vector variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
		/// or IsVectorResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D975 RID: 121205 RVA: 0x0029CAF4 File Offset: 0x0029ACF4
		public bool GetVectorVariableNeeded(int i)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableNeeded_20(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0601D976 RID: 121206
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExprTkFunctionParser_GetVectorVariableNeeded_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Returns whether a vector variable is needed for the function evaluation.
		/// This is only valid after a successful Parse(). Thus, call GetVectorResult()
		/// or IsVectorResult() or similar method before calling this.
		/// </summary>
		// Token: 0x0601D977 RID: 121207 RVA: 0x0029CB1C File Offset: 0x0029AD1C
		public bool GetVectorVariableNeeded(string variableName)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableNeeded_21(base.GetCppThis(), variableName) != 0;
		}

		// Token: 0x0601D978 RID: 121208
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_GetVectorVariableValue_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D979 RID: 121209 RVA: 0x0029CB44 File Offset: 0x0029AD44
		public IntPtr GetVectorVariableValue(string variableName)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableValue_22(base.GetCppThis(), variableName);
		}

		// Token: 0x0601D97A RID: 121210
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_GetVectorVariableValue_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, IntPtr value);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D97B RID: 121211 RVA: 0x0029CB64 File Offset: 0x0029AD64
		public void GetVectorVariableValue(string variableName, IntPtr value)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableValue_23(base.GetCppThis(), variableName, value);
		}

		// Token: 0x0601D97C RID: 121212
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_GetVectorVariableValue_24(HandleRef pThis, int i);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D97D RID: 121213 RVA: 0x0029CB78 File Offset: 0x0029AD78
		public IntPtr GetVectorVariableValue(int i)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableValue_24(base.GetCppThis(), i);
		}

		// Token: 0x0601D97E RID: 121214
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_GetVectorVariableValue_25(HandleRef pThis, int i, IntPtr value);

		/// <summary>
		/// Get the value of a vector variable.
		/// </summary>
		// Token: 0x0601D97F RID: 121215 RVA: 0x0029CB98 File Offset: 0x0029AD98
		public void GetVectorVariableValue(int i, IntPtr value)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_GetVectorVariableValue_25(base.GetCppThis(), i, value);
		}

		// Token: 0x0601D980 RID: 121216
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_InvalidateFunction_26(HandleRef pThis);

		/// <summary>
		/// Allow the user to force the function to be re-parsed
		/// </summary>
		// Token: 0x0601D981 RID: 121217 RVA: 0x0029CBA9 File Offset: 0x0029ADA9
		public void InvalidateFunction()
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_InvalidateFunction_26(base.GetCppThis());
		}

		// Token: 0x0601D982 RID: 121218
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D983 RID: 121219 RVA: 0x0029CBB8 File Offset: 0x0029ADB8
		public override int IsA(string type)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0601D984 RID: 121220
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_IsScalarResult_28(HandleRef pThis);

		/// <summary>
		/// Check whether the result is a scalar result.  If it isn't, then
		/// either the result is a vector or an error has occurred.
		/// </summary>
		// Token: 0x0601D985 RID: 121221 RVA: 0x0029CBD8 File Offset: 0x0029ADD8
		public int IsScalarResult()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_IsScalarResult_28(base.GetCppThis());
		}

		// Token: 0x0601D986 RID: 121222
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D987 RID: 121223 RVA: 0x0029CBF8 File Offset: 0x0029ADF8
		public new static int IsTypeOf(string type)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_IsTypeOf_29(type);
		}

		// Token: 0x0601D988 RID: 121224
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExprTkFunctionParser_IsVectorResult_30(HandleRef pThis);

		/// <summary>
		/// Check whether the result is a vector result.  If it isn't, then
		/// either the result is scalar or an error has occurred.
		/// </summary>
		// Token: 0x0601D989 RID: 121225 RVA: 0x0029CC14 File Offset: 0x0029AE14
		public int IsVectorResult()
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_IsVectorResult_30(base.GetCppThis());
		}

		// Token: 0x0601D98A RID: 121226
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D98B RID: 121227 RVA: 0x0029CC34 File Offset: 0x0029AE34
		public new vtkExprTkFunctionParser NewInstance()
		{
			vtkExprTkFunctionParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExprTkFunctionParser.vtkExprTkFunctionParser_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExprTkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D98C RID: 121228
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_RemoveAllVariables_33(HandleRef pThis);

		/// <summary>
		/// Remove all the current variables.
		/// </summary>
		// Token: 0x0601D98D RID: 121229 RVA: 0x0029CC8E File Offset: 0x0029AE8E
		public void RemoveAllVariables()
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_RemoveAllVariables_33(base.GetCppThis());
		}

		// Token: 0x0601D98E RID: 121230
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_RemoveScalarVariables_34(HandleRef pThis);

		/// <summary>
		/// Remove all the scalar variables.
		/// </summary>
		// Token: 0x0601D98F RID: 121231 RVA: 0x0029CC9D File Offset: 0x0029AE9D
		public void RemoveScalarVariables()
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_RemoveScalarVariables_34(base.GetCppThis());
		}

		// Token: 0x0601D990 RID: 121232
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_RemoveVectorVariables_35(HandleRef pThis);

		/// <summary>
		/// Remove all the vector variables.
		/// </summary>
		// Token: 0x0601D991 RID: 121233 RVA: 0x0029CCAC File Offset: 0x0029AEAC
		public void RemoveVectorVariables()
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_RemoveVectorVariables_35(base.GetCppThis());
		}

		// Token: 0x0601D992 RID: 121234
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_ReplaceInvalidValuesOff_36(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D993 RID: 121235 RVA: 0x0029CCBB File Offset: 0x0029AEBB
		public virtual void ReplaceInvalidValuesOff()
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_ReplaceInvalidValuesOff_36(base.GetCppThis());
		}

		// Token: 0x0601D994 RID: 121236
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_ReplaceInvalidValuesOn_37(HandleRef pThis);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D995 RID: 121237 RVA: 0x0029CCCA File Offset: 0x0029AECA
		public virtual void ReplaceInvalidValuesOn()
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_ReplaceInvalidValuesOn_37(base.GetCppThis());
		}

		// Token: 0x0601D996 RID: 121238
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExprTkFunctionParser_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D997 RID: 121239 RVA: 0x0029CCDC File Offset: 0x0029AEDC
		public new static vtkExprTkFunctionParser SafeDownCast(vtkObjectBase o)
		{
			vtkExprTkFunctionParser vtkExprTkFunctionParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExprTkFunctionParser.vtkExprTkFunctionParser_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExprTkFunctionParser = (vtkExprTkFunctionParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExprTkFunctionParser.Register(null);
				}
			}
			return vtkExprTkFunctionParser;
		}

		// Token: 0x0601D998 RID: 121240
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkExprTkFunctionParser_SanitizeName_39([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Sanitize a label/name to remove spaces, delimiters etc.
		/// Once the label/name is sanitized is can be accepted by the
		/// following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		///
		/// @note taken from vtkSMCoreUtilities
		/// </summary>
		// Token: 0x0601D999 RID: 121241 RVA: 0x0029CD5C File Offset: 0x0029AF5C
		public static string SanitizeName(string name)
		{
			return vtkExprTkFunctionParser.vtkExprTkFunctionParser_SanitizeName_39(name);
		}

		// Token: 0x0601D99A RID: 121242
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetFunction_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string function);

		/// <summary>
		/// Set/Get input string to evaluate.
		/// </summary>
		// Token: 0x0601D99B RID: 121243 RVA: 0x0029CD76 File Offset: 0x0029AF76
		public void SetFunction(string function)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetFunction_40(base.GetCppThis(), function);
		}

		// Token: 0x0601D99C RID: 121244
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetReplaceInvalidValues_41(HandleRef pThis, int _arg);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D99D RID: 121245 RVA: 0x0029CD86 File Offset: 0x0029AF86
		public virtual void SetReplaceInvalidValues(int _arg)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetReplaceInvalidValues_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D99E RID: 121246
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetReplacementValue_42(HandleRef pThis, double _arg);

		/// <summary>
		/// When ReplaceInvalidValues is on, all invalid values (such as
		/// sqrt(-2), note that function parser does not handle complex
		/// numbers) will be replaced by ReplacementValue. Otherwise an
		/// error will be reported
		/// </summary>
		// Token: 0x0601D99F RID: 121247 RVA: 0x0029CD96 File Offset: 0x0029AF96
		public virtual void SetReplacementValue(double _arg)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetReplacementValue_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D9A0 RID: 121248
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetScalarVariableValue_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, double value);

		/// <summary>
		/// Set the value of a scalar variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value. If the
		/// variable name is not sanitized, it should be provided in quotes, and
		/// a valid unique string will be used as a replacement by the parser.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x0601D9A1 RID: 121249 RVA: 0x0029CDA6 File Offset: 0x0029AFA6
		public void SetScalarVariableValue(string variableName, double value)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetScalarVariableValue_43(base.GetCppThis(), variableName, value);
		}

		// Token: 0x0601D9A2 RID: 121250
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetScalarVariableValue_44(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set the value of a scalar variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value. If the
		/// variable name is not sanitized, it should be provided in quotes, and
		/// a valid unique string will be used as a replacement by the parser.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x0601D9A3 RID: 121251 RVA: 0x0029CDB7 File Offset: 0x0029AFB7
		public void SetScalarVariableValue(int i, double value)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetScalarVariableValue_44(base.GetCppThis(), i, value);
		}

		// Token: 0x0601D9A4 RID: 121252
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, double xValue, double yValue, double zValue);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value. If the
		/// variable name is not sanitized, it should be provided in quotes, and
		/// a valid unique string will be used as a replacement by the parser.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x0601D9A5 RID: 121253 RVA: 0x0029CDC8 File Offset: 0x0029AFC8
		public void SetVectorVariableValue(string variableName, double xValue, double yValue, double zValue)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetVectorVariableValue_45(base.GetCppThis(), variableName, xValue, yValue, zValue);
		}

		// Token: 0x0601D9A6 RID: 121254
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string variableName, IntPtr values);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value. If the
		/// variable name is not sanitized, it should be provided in quotes, and
		/// a valid unique string will be used as a replacement by the parser.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x0601D9A7 RID: 121255 RVA: 0x0029CDDC File Offset: 0x0029AFDC
		public void SetVectorVariableValue(string variableName, IntPtr values)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetVectorVariableValue_46(base.GetCppThis(), variableName, values);
		}

		// Token: 0x0601D9A8 RID: 121256
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_47(HandleRef pThis, int i, double xValue, double yValue, double zValue);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value. If the
		/// variable name is not sanitized, it should be provided in quotes, and
		/// a valid unique string will be used as a replacement by the parser.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x0601D9A9 RID: 121257 RVA: 0x0029CDED File Offset: 0x0029AFED
		public void SetVectorVariableValue(int i, double xValue, double yValue, double zValue)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetVectorVariableValue_47(base.GetCppThis(), i, xValue, yValue, zValue);
		}

		// Token: 0x0601D9AA RID: 121258
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExprTkFunctionParser_SetVectorVariableValue_48(HandleRef pThis, int i, IntPtr values);

		/// <summary>
		/// Set the value of a vector variable.  If a variable with this name
		/// exists, then its value will be set to the new value.  If there is not
		/// already a variable with this name, variableName will be added to the
		/// list of variables, and its value will be set to the new value. If the
		/// variable name is not sanitized, it should be provided in quotes, and
		/// a valid unique string will be used as a replacement by the parser.
		///
		/// @note A sanitized variable name is accepted by the following regex: ^[a-zA-Z][a-zA-Z_0-9]*.
		/// </summary>
		// Token: 0x0601D9AB RID: 121259 RVA: 0x0029CE01 File Offset: 0x0029B001
		public void SetVectorVariableValue(int i, IntPtr values)
		{
			vtkExprTkFunctionParser.vtkExprTkFunctionParser_SetVectorVariableValue_48(base.GetCppThis(), i, values);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F33 RID: 7987
		public new const string MRFullTypeName = "Kitware.VTK.vtkExprTkFunctionParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F34 RID: 7988
		public new static readonly string MRClassNameKey = "class vtkExprTkFunctionParser";
	}
}
