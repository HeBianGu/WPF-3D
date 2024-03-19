using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDSPFilterDefinition
	/// </summary>
	/// <remarks>
	///    used by the Exodus readers
	///
	/// vtkDSPFilterDefinition is used by vtkExodusReader, vtkExodusIIReader and
	/// vtkPExodusReader to do temporal smoothing of data
	/// </remarks>
	/// <seealso>
	///
	/// vtkDSPFilterGroup vtkExodusReader vtkExodusIIReader vtkPExodusReader
	/// </seealso>
	// Token: 0x02000606 RID: 1542
	public class vtkDSPFilterDefinition : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010BCE RID: 68558 RVA: 0x001757BB File Offset: 0x001739BB
		static vtkDSPFilterDefinition()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDSPFilterDefinition.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDSPFilterDefinition"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010BCF RID: 68559 RVA: 0x001757E3 File Offset: 0x001739E3
		public vtkDSPFilterDefinition(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010BD0 RID: 68560
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterDefinition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BD1 RID: 68561 RVA: 0x001757F4 File Offset: 0x001739F4
		public new static vtkDSPFilterDefinition New()
		{
			vtkDSPFilterDefinition result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterDefinition.vtkDSPFilterDefinition_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BD2 RID: 68562 RVA: 0x00175848 File Offset: 0x00173A48
		public vtkDSPFilterDefinition() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDSPFilterDefinition.vtkDSPFilterDefinition_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010BD3 RID: 68563 RVA: 0x0017588C File Offset: 0x00173A8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010BD4 RID: 68564
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_Clear_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BD5 RID: 68565 RVA: 0x00175897 File Offset: 0x00173A97
		public void Clear()
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_Clear_01(base.GetCppThis());
		}

		// Token: 0x06010BD6 RID: 68566
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_Copy_02(HandleRef pThis, HandleRef other);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BD7 RID: 68567 RVA: 0x001758A8 File Offset: 0x00173AA8
		public void Copy(vtkDSPFilterDefinition other)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_Copy_02(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x06010BD8 RID: 68568
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDSPFilterDefinition_GetDenominatorWeight_03(HandleRef pThis, int a_which);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BD9 RID: 68569 RVA: 0x001758D8 File Offset: 0x00173AD8
		public double GetDenominatorWeight(int a_which)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetDenominatorWeight_03(base.GetCppThis(), a_which);
		}

		// Token: 0x06010BDA RID: 68570
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDSPFilterDefinition_GetForwardNumeratorWeight_04(HandleRef pThis, int a_which);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BDB RID: 68571 RVA: 0x001758F8 File Offset: 0x00173AF8
		public double GetForwardNumeratorWeight(int a_which)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetForwardNumeratorWeight_04(base.GetCppThis(), a_which);
		}

		// Token: 0x06010BDC RID: 68572
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterDefinition_GetInputVariableName_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BDD RID: 68573 RVA: 0x00175918 File Offset: 0x00173B18
		public string GetInputVariableName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetInputVariableName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010BDE RID: 68574
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterDefinition_GetNumDenominatorWeights_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BDF RID: 68575 RVA: 0x00175954 File Offset: 0x00173B54
		public int GetNumDenominatorWeights()
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumDenominatorWeights_06(base.GetCppThis());
		}

		// Token: 0x06010BE0 RID: 68576
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterDefinition_GetNumForwardNumeratorWeights_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BE1 RID: 68577 RVA: 0x00175974 File Offset: 0x00173B74
		public int GetNumForwardNumeratorWeights()
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumForwardNumeratorWeights_07(base.GetCppThis());
		}

		// Token: 0x06010BE2 RID: 68578
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterDefinition_GetNumNumeratorWeights_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BE3 RID: 68579 RVA: 0x00175994 File Offset: 0x00173B94
		public int GetNumNumeratorWeights()
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumNumeratorWeights_08(base.GetCppThis());
		}

		// Token: 0x06010BE4 RID: 68580
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDSPFilterDefinition_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BE5 RID: 68581 RVA: 0x001759B4 File Offset: 0x00173BB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06010BE6 RID: 68582
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDSPFilterDefinition_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BE7 RID: 68583 RVA: 0x001759D4 File Offset: 0x00173BD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06010BE8 RID: 68584
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDSPFilterDefinition_GetNumeratorWeight_11(HandleRef pThis, int a_which);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BE9 RID: 68585 RVA: 0x001759F0 File Offset: 0x00173BF0
		public double GetNumeratorWeight(int a_which)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetNumeratorWeight_11(base.GetCppThis(), a_which);
		}

		// Token: 0x06010BEA RID: 68586
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterDefinition_GetOutputVariableName_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BEB RID: 68587 RVA: 0x00175A10 File Offset: 0x00173C10
		public string GetOutputVariableName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDSPFilterDefinition.vtkDSPFilterDefinition_GetOutputVariableName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010BEC RID: 68588
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterDefinition_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BED RID: 68589 RVA: 0x00175A4C File Offset: 0x00173C4C
		public override int IsA(string type)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06010BEE RID: 68590
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDSPFilterDefinition_IsThisInputVariableInstanceNeeded_14(HandleRef pThis, int a_timestep, int a_outputTimestep);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BEF RID: 68591 RVA: 0x00175A6C File Offset: 0x00173C6C
		public bool IsThisInputVariableInstanceNeeded(int a_timestep, int a_outputTimestep)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_IsThisInputVariableInstanceNeeded_14(base.GetCppThis(), a_timestep, a_outputTimestep) != 0;
		}

		// Token: 0x06010BF0 RID: 68592
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterDefinition_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BF1 RID: 68593 RVA: 0x00175A94 File Offset: 0x00173C94
		public new static int IsTypeOf(string type)
		{
			return vtkDSPFilterDefinition.vtkDSPFilterDefinition_IsTypeOf_15(type);
		}

		// Token: 0x06010BF2 RID: 68594
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterDefinition_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BF3 RID: 68595 RVA: 0x00175AB0 File Offset: 0x00173CB0
		public new vtkDSPFilterDefinition NewInstance()
		{
			vtkDSPFilterDefinition result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterDefinition.vtkDSPFilterDefinition_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010BF4 RID: 68596
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_PushBackDenominatorWeight_18(HandleRef pThis, double a_value);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BF5 RID: 68597 RVA: 0x00175B0A File Offset: 0x00173D0A
		public void PushBackDenominatorWeight(double a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_PushBackDenominatorWeight_18(base.GetCppThis(), a_value);
		}

		// Token: 0x06010BF6 RID: 68598
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_PushBackForwardNumeratorWeight_19(HandleRef pThis, double a_value);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BF7 RID: 68599 RVA: 0x00175B1A File Offset: 0x00173D1A
		public void PushBackForwardNumeratorWeight(double a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_PushBackForwardNumeratorWeight_19(base.GetCppThis(), a_value);
		}

		// Token: 0x06010BF8 RID: 68600
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_PushBackNumeratorWeight_20(HandleRef pThis, double a_value);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BF9 RID: 68601 RVA: 0x00175B2A File Offset: 0x00173D2A
		public void PushBackNumeratorWeight(double a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_PushBackNumeratorWeight_20(base.GetCppThis(), a_value);
		}

		// Token: 0x06010BFA RID: 68602
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterDefinition_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BFB RID: 68603 RVA: 0x00175B3C File Offset: 0x00173D3C
		public new static vtkDSPFilterDefinition SafeDownCast(vtkObjectBase o)
		{
			vtkDSPFilterDefinition vtkDSPFilterDefinition = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterDefinition.vtkDSPFilterDefinition_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDSPFilterDefinition = (vtkDSPFilterDefinition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDSPFilterDefinition.Register(null);
				}
			}
			return vtkDSPFilterDefinition;
		}

		// Token: 0x06010BFC RID: 68604
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_SetInputVariableName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a_value);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BFD RID: 68605 RVA: 0x00175BBB File Offset: 0x00173DBB
		public void SetInputVariableName(string a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_SetInputVariableName_22(base.GetCppThis(), a_value);
		}

		// Token: 0x06010BFE RID: 68606
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterDefinition_SetOutputVariableName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a_value);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010BFF RID: 68607 RVA: 0x00175BCB File Offset: 0x00173DCB
		public void SetOutputVariableName(string a_value)
		{
			vtkDSPFilterDefinition.vtkDSPFilterDefinition_SetOutputVariableName_23(base.GetCppThis(), a_value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001366 RID: 4966
		public new const string MRFullTypeName = "Kitware.VTK.vtkDSPFilterDefinition";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001367 RID: 4967
		public new static readonly string MRClassNameKey = "class vtkDSPFilterDefinition";
	}
}
