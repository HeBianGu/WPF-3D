using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDSPFilterGroup
	/// </summary>
	/// <remarks>
	///    used by the Exodus readers
	///
	/// vtkDSPFilterGroup is used by vtkExodusReader, vtkExodusIIReader and
	/// vtkPExodusReader to do temporal smoothing of data
	/// </remarks>
	/// <seealso>
	///
	/// vtkDSPFilterDefinition vtkExodusReader vtkExodusIIReader vtkPExodusReader
	/// </seealso>
	// Token: 0x02000607 RID: 1543
	public class vtkDSPFilterGroup : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010C00 RID: 68608 RVA: 0x00175BDB File Offset: 0x00173DDB
		static vtkDSPFilterGroup()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDSPFilterGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDSPFilterGroup"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010C01 RID: 68609 RVA: 0x00175C03 File Offset: 0x00173E03
		public vtkDSPFilterGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010C02 RID: 68610
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C03 RID: 68611 RVA: 0x00175C14 File Offset: 0x00173E14
		public new static vtkDSPFilterGroup New()
		{
			vtkDSPFilterGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C04 RID: 68612 RVA: 0x00175C68 File Offset: 0x00173E68
		public vtkDSPFilterGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDSPFilterGroup.vtkDSPFilterGroup_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010C05 RID: 68613 RVA: 0x00175CAC File Offset: 0x00173EAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010C06 RID: 68614
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterGroup_AddFilter_01(HandleRef pThis, HandleRef filter);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C07 RID: 68615 RVA: 0x00175CB8 File Offset: 0x00173EB8
		public void AddFilter(vtkDSPFilterDefinition filter)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_AddFilter_01(base.GetCppThis(), (filter == null) ? default(HandleRef) : filter.GetCppThis());
		}

		// Token: 0x06010C08 RID: 68616
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterGroup_AddInputVariableInstance_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a_name, int a_timestep, HandleRef a_data);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C09 RID: 68617 RVA: 0x00175CE8 File Offset: 0x00173EE8
		public void AddInputVariableInstance(string a_name, int a_timestep, vtkFloatArray a_data)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_AddInputVariableInstance_02(base.GetCppThis(), a_name, a_timestep, (a_data == null) ? default(HandleRef) : a_data.GetCppThis());
		}

		// Token: 0x06010C0A RID: 68618
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterGroup_Copy_03(HandleRef pThis, HandleRef other);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C0B RID: 68619 RVA: 0x00175D1C File Offset: 0x00173F1C
		public void Copy(vtkDSPFilterGroup other)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_Copy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x06010C0C RID: 68620
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_GetCachedInput_04(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C0D RID: 68621 RVA: 0x00175D4C File Offset: 0x00173F4C
		public vtkFloatArray GetCachedInput(int a_whichFilter, int a_whichTimestep)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetCachedInput_04(base.GetCppThis(), a_whichFilter, a_whichTimestep, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x06010C0E RID: 68622
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_GetCachedOutput_05(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C0F RID: 68623 RVA: 0x00175DC0 File Offset: 0x00173FC0
		public vtkFloatArray GetCachedOutput(int a_whichFilter, int a_whichTimestep)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetCachedOutput_05(base.GetCppThis(), a_whichFilter, a_whichTimestep, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x06010C10 RID: 68624
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_GetFilter_06(HandleRef pThis, int a_whichFilter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C11 RID: 68625 RVA: 0x00175E34 File Offset: 0x00174034
		public vtkDSPFilterDefinition GetFilter(int a_whichFilter)
		{
			vtkDSPFilterDefinition vtkDSPFilterDefinition = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetFilter_06(base.GetCppThis(), a_whichFilter, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010C12 RID: 68626
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_GetInputVariableName_07(HandleRef pThis, int a_whichFilter);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C13 RID: 68627 RVA: 0x00175EA4 File Offset: 0x001740A4
		public string GetInputVariableName(int a_whichFilter)
		{
			string s = Marshal.PtrToStringAnsi(vtkDSPFilterGroup.vtkDSPFilterGroup_GetInputVariableName_07(base.GetCppThis(), a_whichFilter));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010C14 RID: 68628
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterGroup_GetNumFilters_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C15 RID: 68629 RVA: 0x00175EE0 File Offset: 0x001740E0
		public int GetNumFilters()
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_GetNumFilters_08(base.GetCppThis());
		}

		// Token: 0x06010C16 RID: 68630
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDSPFilterGroup_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C17 RID: 68631 RVA: 0x00175F00 File Offset: 0x00174100
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06010C18 RID: 68632
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDSPFilterGroup_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C19 RID: 68633 RVA: 0x00175F20 File Offset: 0x00174120
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06010C1A RID: 68634
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_GetOutput_11(HandleRef pThis, int a_whichFilter, int a_whichTimestep, ref int a_instancesCalculated, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C1B RID: 68635 RVA: 0x00175F3C File Offset: 0x0017413C
		public vtkFloatArray GetOutput(int a_whichFilter, int a_whichTimestep, ref int a_instancesCalculated)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_GetOutput_11(base.GetCppThis(), a_whichFilter, a_whichTimestep, ref a_instancesCalculated, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x06010C1C RID: 68636
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterGroup_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C1D RID: 68637 RVA: 0x00175FB0 File Offset: 0x001741B0
		public override int IsA(string type)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06010C1E RID: 68638
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDSPFilterGroup_IsThisInputVariableInstanceCached_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a_name, int a_timestep);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C1F RID: 68639 RVA: 0x00175FD0 File Offset: 0x001741D0
		public bool IsThisInputVariableInstanceCached(string a_name, int a_timestep)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsThisInputVariableInstanceCached_13(base.GetCppThis(), a_name, a_timestep) != 0;
		}

		// Token: 0x06010C20 RID: 68640
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDSPFilterGroup_IsThisInputVariableInstanceNeeded_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a_name, int a_timestep, int a_outputTimestep);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C21 RID: 68641 RVA: 0x00175FF8 File Offset: 0x001741F8
		public bool IsThisInputVariableInstanceNeeded(string a_name, int a_timestep, int a_outputTimestep)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsThisInputVariableInstanceNeeded_14(base.GetCppThis(), a_name, a_timestep, a_outputTimestep) != 0;
		}

		// Token: 0x06010C22 RID: 68642
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDSPFilterGroup_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C23 RID: 68643 RVA: 0x00176024 File Offset: 0x00174224
		public new static int IsTypeOf(string type)
		{
			return vtkDSPFilterGroup.vtkDSPFilterGroup_IsTypeOf_15(type);
		}

		// Token: 0x06010C24 RID: 68644
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C25 RID: 68645 RVA: 0x00176040 File Offset: 0x00174240
		public new vtkDSPFilterGroup NewInstance()
		{
			vtkDSPFilterGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010C26 RID: 68646
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDSPFilterGroup_RemoveFilter_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string a_outputVariableName);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C27 RID: 68647 RVA: 0x0017609A File Offset: 0x0017429A
		public void RemoveFilter(string a_outputVariableName)
		{
			vtkDSPFilterGroup.vtkDSPFilterGroup_RemoveFilter_18(base.GetCppThis(), a_outputVariableName);
		}

		// Token: 0x06010C28 RID: 68648
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDSPFilterGroup_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C29 RID: 68649 RVA: 0x001760AC File Offset: 0x001742AC
		public new static vtkDSPFilterGroup SafeDownCast(vtkObjectBase o)
		{
			vtkDSPFilterGroup vtkDSPFilterGroup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDSPFilterGroup.vtkDSPFilterGroup_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDSPFilterGroup = (vtkDSPFilterGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDSPFilterGroup.Register(null);
				}
			}
			return vtkDSPFilterGroup;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001368 RID: 4968
		public new const string MRFullTypeName = "Kitware.VTK.vtkDSPFilterGroup";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001369 RID: 4969
		public new static readonly string MRClassNameKey = "class vtkDSPFilterGroup";
	}
}
