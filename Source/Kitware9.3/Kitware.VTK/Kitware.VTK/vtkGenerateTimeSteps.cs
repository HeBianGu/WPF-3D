using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenerateTimeSteps
	/// </summary>
	/// <remarks>
	///    Generate timesteps on any input
	///
	/// A vtkPassInputTypeAlgorithm that add timesteps during the request information
	/// pass and just shallow copy its input to its output. Input timesteps are completely
	/// ignored.
	/// </remarks>
	// Token: 0x0200060B RID: 1547
	public class vtkGenerateTimeSteps : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010C8A RID: 68746 RVA: 0x001769DB File Offset: 0x00174BDB
		static vtkGenerateTimeSteps()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenerateTimeSteps.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenerateTimeSteps"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010C8B RID: 68747 RVA: 0x00176A03 File Offset: 0x00174C03
		public vtkGenerateTimeSteps(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010C8C RID: 68748
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateTimeSteps_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C8D RID: 68749 RVA: 0x00176A14 File Offset: 0x00174C14
		public new static vtkGenerateTimeSteps New()
		{
			vtkGenerateTimeSteps result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateTimeSteps.vtkGenerateTimeSteps_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateTimeSteps)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C8E RID: 68750 RVA: 0x00176A68 File Offset: 0x00174C68
		public vtkGenerateTimeSteps() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenerateTimeSteps.vtkGenerateTimeSteps_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010C8F RID: 68751 RVA: 0x00176AAC File Offset: 0x00174CAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010C90 RID: 68752
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateTimeSteps_AddTimeStepValue_01(HandleRef pThis, double timeStepValue);

		/// <summary>
		/// Add a time step value.
		/// </summary>
		// Token: 0x06010C91 RID: 68753 RVA: 0x00176AB7 File Offset: 0x00174CB7
		public void AddTimeStepValue(double timeStepValue)
		{
			vtkGenerateTimeSteps.vtkGenerateTimeSteps_AddTimeStepValue_01(base.GetCppThis(), timeStepValue);
		}

		// Token: 0x06010C92 RID: 68754
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateTimeSteps_ClearTimeStepValues_02(HandleRef pThis);

		/// <summary>
		/// Clear the time step values
		/// </summary>
		// Token: 0x06010C93 RID: 68755 RVA: 0x00176AC7 File Offset: 0x00174CC7
		public void ClearTimeStepValues()
		{
			vtkGenerateTimeSteps.vtkGenerateTimeSteps_ClearTimeStepValues_02(base.GetCppThis());
		}

		// Token: 0x06010C94 RID: 68756
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateTimeSteps_GenerateTimeStepValues_03(HandleRef pThis, double begin, double end, double step);

		/// <summary>
		/// Generate a range of values in [begin, end) with a step size of 'step'
		/// </summary>
		// Token: 0x06010C95 RID: 68757 RVA: 0x00176AD6 File Offset: 0x00174CD6
		public void GenerateTimeStepValues(double begin, double end, double step)
		{
			vtkGenerateTimeSteps.vtkGenerateTimeSteps_GenerateTimeStepValues_03(base.GetCppThis(), begin, end, step);
		}

		// Token: 0x06010C96 RID: 68758
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenerateTimeSteps_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C97 RID: 68759 RVA: 0x00176AE8 File Offset: 0x00174CE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenerateTimeSteps.vtkGenerateTimeSteps_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06010C98 RID: 68760
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenerateTimeSteps_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C99 RID: 68761 RVA: 0x00176B08 File Offset: 0x00174D08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenerateTimeSteps.vtkGenerateTimeSteps_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06010C9A RID: 68762
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateTimeSteps_GetNumberOfTimeSteps_06(HandleRef pThis);

		/// <summary>
		/// Get the number of time steps that will be extracted
		/// </summary>
		// Token: 0x06010C9B RID: 68763 RVA: 0x00176B24 File Offset: 0x00174D24
		public int GetNumberOfTimeSteps()
		{
			return vtkGenerateTimeSteps.vtkGenerateTimeSteps_GetNumberOfTimeSteps_06(base.GetCppThis());
		}

		// Token: 0x06010C9C RID: 68764
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateTimeSteps_GetTimeStepValues_07(HandleRef pThis, IntPtr timeStepValues);

		/// <summary>
		/// Get/Set an array of time step values. For the Get function,
		/// timeStepValues should be big enough for GetNumberOfTimeSteps() values.
		/// </summary>
		// Token: 0x06010C9D RID: 68765 RVA: 0x00176B43 File Offset: 0x00174D43
		public void GetTimeStepValues(IntPtr timeStepValues)
		{
			vtkGenerateTimeSteps.vtkGenerateTimeSteps_GetTimeStepValues_07(base.GetCppThis(), timeStepValues);
		}

		// Token: 0x06010C9E RID: 68766
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateTimeSteps_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C9F RID: 68767 RVA: 0x00176B54 File Offset: 0x00174D54
		public override int IsA(string type)
		{
			return vtkGenerateTimeSteps.vtkGenerateTimeSteps_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06010CA0 RID: 68768
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateTimeSteps_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CA1 RID: 68769 RVA: 0x00176B74 File Offset: 0x00174D74
		public new static int IsTypeOf(string type)
		{
			return vtkGenerateTimeSteps.vtkGenerateTimeSteps_IsTypeOf_09(type);
		}

		// Token: 0x06010CA2 RID: 68770
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateTimeSteps_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CA3 RID: 68771 RVA: 0x00176B90 File Offset: 0x00174D90
		public new vtkGenerateTimeSteps NewInstance()
		{
			vtkGenerateTimeSteps result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateTimeSteps.vtkGenerateTimeSteps_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateTimeSteps)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010CA4 RID: 68772
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateTimeSteps_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CA5 RID: 68773 RVA: 0x00176BEC File Offset: 0x00174DEC
		public new static vtkGenerateTimeSteps SafeDownCast(vtkObjectBase o)
		{
			vtkGenerateTimeSteps vtkGenerateTimeSteps = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateTimeSteps.vtkGenerateTimeSteps_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenerateTimeSteps = (vtkGenerateTimeSteps)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenerateTimeSteps.Register(null);
				}
			}
			return vtkGenerateTimeSteps;
		}

		// Token: 0x06010CA6 RID: 68774
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateTimeSteps_SetTimeStepValues_13(HandleRef pThis, int count, IntPtr timeStepValues);

		/// <summary>
		/// Get/Set an array of time step values. For the Get function,
		/// timeStepValues should be big enough for GetNumberOfTimeSteps() values.
		/// </summary>
		// Token: 0x06010CA7 RID: 68775 RVA: 0x00176C6B File Offset: 0x00174E6B
		public void SetTimeStepValues(int count, IntPtr timeStepValues)
		{
			vtkGenerateTimeSteps.vtkGenerateTimeSteps_SetTimeStepValues_13(base.GetCppThis(), count, timeStepValues);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001370 RID: 4976
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenerateTimeSteps";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001371 RID: 4977
		public new static readonly string MRClassNameKey = "class vtkGenerateTimeSteps";
	}
}
