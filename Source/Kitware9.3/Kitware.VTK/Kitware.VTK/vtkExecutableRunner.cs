using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExecutableRunner
	/// </summary>
	/// <remarks>
	///    Launch a process on the current machine and get its output
	///
	/// Launch a process on the current machine and get its standard output and
	/// standard error output. When `ExecuteInSystemShell` is false, arguments
	/// needs to be added separately using the `AddArgument` / `ClearArguments`
	/// API, otherwise command may not work correctly. If one does not know how to
	/// parse the arguments of the command it want to execute then
	/// `ExecuteInSystemShell` should be set to true.
	/// </remarks>
	// Token: 0x02000AFA RID: 2810
	public class vtkExecutableRunner : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D86B RID: 120939 RVA: 0x0029B563 File Offset: 0x00299763
		static vtkExecutableRunner()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutableRunner.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutableRunner"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D86C RID: 120940 RVA: 0x0029B58B File Offset: 0x0029978B
		public vtkExecutableRunner(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D86D RID: 120941
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutableRunner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D86E RID: 120942 RVA: 0x0029B59C File Offset: 0x0029979C
		public new static vtkExecutableRunner New()
		{
			vtkExecutableRunner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutableRunner.vtkExecutableRunner_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutableRunner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D86F RID: 120943 RVA: 0x0029B5F0 File Offset: 0x002997F0
		public vtkExecutableRunner() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExecutableRunner.vtkExecutableRunner_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D870 RID: 120944 RVA: 0x0029B634 File Offset: 0x00299834
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D871 RID: 120945
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_AddArgument_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// API to control arguments passed to the command when `ExecuteInSystemShell`
		/// is false.
		///
		/// Default is no argument.
		/// </summary>
		// Token: 0x0601D872 RID: 120946 RVA: 0x0029B63F File Offset: 0x0029983F
		public virtual void AddArgument(string arg)
		{
			vtkExecutableRunner.vtkExecutableRunner_AddArgument_01(base.GetCppThis(), arg);
		}

		// Token: 0x0601D873 RID: 120947
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_ClearArguments_02(HandleRef pThis);

		/// <summary>
		/// API to control arguments passed to the command when `ExecuteInSystemShell`
		/// is false.
		///
		/// Default is no argument.
		/// </summary>
		// Token: 0x0601D874 RID: 120948 RVA: 0x0029B64F File Offset: 0x0029984F
		public virtual void ClearArguments()
		{
			vtkExecutableRunner.vtkExecutableRunner_ClearArguments_02(base.GetCppThis());
		}

		// Token: 0x0601D875 RID: 120949
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_Execute_03(HandleRef pThis);

		/// <summary>
		/// Execute the command currently set if any.
		/// This will update the StdOut and StdErr properties.
		/// </summary>
		// Token: 0x0601D876 RID: 120950 RVA: 0x0029B65E File Offset: 0x0029985E
		public void Execute()
		{
			vtkExecutableRunner.vtkExecutableRunner_Execute_03(base.GetCppThis());
		}

		// Token: 0x0601D877 RID: 120951
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_ExecuteInSystemShellOff_04(HandleRef pThis);

		/// <summary>
		/// Allows the command to be launched using the system shell (`sh` on unix
		/// systems, cmd.exe on windows). This is handy when the user doesn't know
		/// how to split arguments from a single string.
		///
		/// Default to true.
		/// </summary>
		// Token: 0x0601D878 RID: 120952 RVA: 0x0029B66D File Offset: 0x0029986D
		public virtual void ExecuteInSystemShellOff()
		{
			vtkExecutableRunner.vtkExecutableRunner_ExecuteInSystemShellOff_04(base.GetCppThis());
		}

		// Token: 0x0601D879 RID: 120953
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_ExecuteInSystemShellOn_05(HandleRef pThis);

		/// <summary>
		/// Allows the command to be launched using the system shell (`sh` on unix
		/// systems, cmd.exe on windows). This is handy when the user doesn't know
		/// how to split arguments from a single string.
		///
		/// Default to true.
		/// </summary>
		// Token: 0x0601D87A RID: 120954 RVA: 0x0029B67C File Offset: 0x0029987C
		public virtual void ExecuteInSystemShellOn()
		{
			vtkExecutableRunner.vtkExecutableRunner_ExecuteInSystemShellOn_05(base.GetCppThis());
		}

		// Token: 0x0601D87B RID: 120955
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutableRunner_GetCommand_06(HandleRef pThis);

		/// <summary>
		/// Set/Get command to execute. An empty command will do nothing.
		/// </summary>
		// Token: 0x0601D87C RID: 120956 RVA: 0x0029B68C File Offset: 0x0029988C
		public virtual string GetCommand()
		{
			string s = Marshal.PtrToStringAnsi(vtkExecutableRunner.vtkExecutableRunner_GetCommand_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D87D RID: 120957
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExecutableRunner_GetExecuteInSystemShell_07(HandleRef pThis);

		/// <summary>
		/// Allows the command to be launched using the system shell (`sh` on unix
		/// systems, cmd.exe on windows). This is handy when the user doesn't know
		/// how to split arguments from a single string.
		///
		/// Default to true.
		/// </summary>
		// Token: 0x0601D87E RID: 120958 RVA: 0x0029B6C8 File Offset: 0x002998C8
		public virtual bool GetExecuteInSystemShell()
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetExecuteInSystemShell_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D87F RID: 120959
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutableRunner_GetNumberOfArguments_08(HandleRef pThis);

		/// <summary>
		/// API to control arguments passed to the command when `ExecuteInSystemShell`
		/// is false.
		///
		/// Default is no argument.
		/// </summary>
		// Token: 0x0601D880 RID: 120960 RVA: 0x0029B6F0 File Offset: 0x002998F0
		public virtual long GetNumberOfArguments()
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetNumberOfArguments_08(base.GetCppThis());
		}

		// Token: 0x0601D881 RID: 120961
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutableRunner_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D882 RID: 120962 RVA: 0x0029B710 File Offset: 0x00299910
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601D883 RID: 120963
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutableRunner_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D884 RID: 120964 RVA: 0x0029B730 File Offset: 0x00299930
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601D885 RID: 120965
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutableRunner_GetReturnValue_11(HandleRef pThis);

		/// <summary>
		/// Get return value of last command. If no command has been
		/// executed or if the command has failed in some way value is != 0,
		/// else return 0.
		/// </summary>
		// Token: 0x0601D886 RID: 120966 RVA: 0x0029B74C File Offset: 0x0029994C
		public virtual int GetReturnValue()
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetReturnValue_11(base.GetCppThis());
		}

		// Token: 0x0601D887 RID: 120967
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExecutableRunner_GetRightTrimResult_12(HandleRef pThis);

		/// <summary>
		/// Set/Get if we trim the ending whitespaces of the output.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0601D888 RID: 120968 RVA: 0x0029B76C File Offset: 0x0029996C
		public virtual bool GetRightTrimResult()
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetRightTrimResult_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D889 RID: 120969
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutableRunner_GetStdErr_13(HandleRef pThis);

		/// <summary>
		/// Get output of the previously run command.
		/// </summary>
		// Token: 0x0601D88A RID: 120970 RVA: 0x0029B794 File Offset: 0x00299994
		public virtual string GetStdErr()
		{
			string s = Marshal.PtrToStringAnsi(vtkExecutableRunner.vtkExecutableRunner_GetStdErr_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D88B RID: 120971
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutableRunner_GetStdOut_14(HandleRef pThis);

		/// <summary>
		/// Get output of the previously run command.
		/// </summary>
		// Token: 0x0601D88C RID: 120972 RVA: 0x0029B7D0 File Offset: 0x002999D0
		public virtual string GetStdOut()
		{
			string s = Marshal.PtrToStringAnsi(vtkExecutableRunner.vtkExecutableRunner_GetStdOut_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D88D RID: 120973
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExecutableRunner_GetTimeout_15(HandleRef pThis);

		/// <summary>
		/// Set/Get command timeout in seconds.  A non-positive (&lt;= 0) value will
		/// disable the timeout.
		///
		/// Default is 5
		/// </summary>
		// Token: 0x0601D88E RID: 120974 RVA: 0x0029B80C File Offset: 0x00299A0C
		public virtual double GetTimeout()
		{
			return vtkExecutableRunner.vtkExecutableRunner_GetTimeout_15(base.GetCppThis());
		}

		// Token: 0x0601D88F RID: 120975
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutableRunner_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D890 RID: 120976 RVA: 0x0029B82C File Offset: 0x00299A2C
		public override int IsA(string type)
		{
			return vtkExecutableRunner.vtkExecutableRunner_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601D891 RID: 120977
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutableRunner_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D892 RID: 120978 RVA: 0x0029B84C File Offset: 0x00299A4C
		public new static int IsTypeOf(string type)
		{
			return vtkExecutableRunner.vtkExecutableRunner_IsTypeOf_17(type);
		}

		// Token: 0x0601D893 RID: 120979
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutableRunner_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D894 RID: 120980 RVA: 0x0029B868 File Offset: 0x00299A68
		public new vtkExecutableRunner NewInstance()
		{
			vtkExecutableRunner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutableRunner.vtkExecutableRunner_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutableRunner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D895 RID: 120981
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_RightTrimResultOff_20(HandleRef pThis);

		/// <summary>
		/// Set/Get if we trim the ending whitespaces of the output.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0601D896 RID: 120982 RVA: 0x0029B8C2 File Offset: 0x00299AC2
		public virtual void RightTrimResultOff()
		{
			vtkExecutableRunner.vtkExecutableRunner_RightTrimResultOff_20(base.GetCppThis());
		}

		// Token: 0x0601D897 RID: 120983
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_RightTrimResultOn_21(HandleRef pThis);

		/// <summary>
		/// Set/Get if we trim the ending whitespaces of the output.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0601D898 RID: 120984 RVA: 0x0029B8D1 File Offset: 0x00299AD1
		public virtual void RightTrimResultOn()
		{
			vtkExecutableRunner.vtkExecutableRunner_RightTrimResultOn_21(base.GetCppThis());
		}

		// Token: 0x0601D899 RID: 120985
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutableRunner_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D89A RID: 120986 RVA: 0x0029B8E0 File Offset: 0x00299AE0
		public new static vtkExecutableRunner SafeDownCast(vtkObjectBase o)
		{
			vtkExecutableRunner vtkExecutableRunner = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutableRunner.vtkExecutableRunner_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutableRunner = (vtkExecutableRunner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutableRunner.Register(null);
				}
			}
			return vtkExecutableRunner;
		}

		// Token: 0x0601D89B RID: 120987
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_SetCommand_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Set/Get command to execute. An empty command will do nothing.
		/// </summary>
		// Token: 0x0601D89C RID: 120988 RVA: 0x0029B95F File Offset: 0x00299B5F
		public virtual void SetCommand(string arg)
		{
			vtkExecutableRunner.vtkExecutableRunner_SetCommand_23(base.GetCppThis(), arg);
		}

		// Token: 0x0601D89D RID: 120989
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_SetExecuteInSystemShell_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Allows the command to be launched using the system shell (`sh` on unix
		/// systems, cmd.exe on windows). This is handy when the user doesn't know
		/// how to split arguments from a single string.
		///
		/// Default to true.
		/// </summary>
		// Token: 0x0601D89E RID: 120990 RVA: 0x0029B96F File Offset: 0x00299B6F
		public virtual void SetExecuteInSystemShell(bool _arg)
		{
			vtkExecutableRunner.vtkExecutableRunner_SetExecuteInSystemShell_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601D89F RID: 120991
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_SetRightTrimResult_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if we trim the ending whitespaces of the output.
		///
		/// Default is true.
		/// </summary>
		// Token: 0x0601D8A0 RID: 120992 RVA: 0x0029B987 File Offset: 0x00299B87
		public virtual void SetRightTrimResult(bool _arg)
		{
			vtkExecutableRunner.vtkExecutableRunner_SetRightTrimResult_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601D8A1 RID: 120993
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutableRunner_SetTimeout_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get command timeout in seconds.  A non-positive (&lt;= 0) value will
		/// disable the timeout.
		///
		/// Default is 5
		/// </summary>
		// Token: 0x0601D8A2 RID: 120994 RVA: 0x0029B99F File Offset: 0x00299B9F
		public virtual void SetTimeout(double _arg)
		{
			vtkExecutableRunner.vtkExecutableRunner_SetTimeout_26(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F1B RID: 7963
		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutableRunner";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F1C RID: 7964
		public new static readonly string MRClassNameKey = "class vtkExecutableRunner";
	}
}
