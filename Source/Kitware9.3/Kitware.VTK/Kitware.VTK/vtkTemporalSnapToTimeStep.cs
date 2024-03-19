using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalSnapToTimeStep
	/// </summary>
	/// <remarks>
	///    modify the time range/steps of temporal data
	///
	/// vtkTemporalSnapToTimeStep  modify the time range or time steps of
	/// the data without changing the data itself. The data is not resampled
	/// by this filter, only the information accompanying the data is modified.
	///
	/// @par Thanks:
	/// John Bidiscombe of CSCS - Swiss National Supercomputing Centre
	/// for creating and contributing this class.
	/// For related material, please refer to :
	/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
	/// "Time Dependent Processing in a Parallel Pipeline Architecture",
	/// IEEE Visualization 2007.
	/// </remarks>
	// Token: 0x0200061C RID: 1564
	public class vtkTemporalSnapToTimeStep : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010FB8 RID: 69560 RVA: 0x0017A777 File Offset: 0x00178977
		static vtkTemporalSnapToTimeStep()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalSnapToTimeStep.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalSnapToTimeStep"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010FB9 RID: 69561 RVA: 0x0017A79F File Offset: 0x0017899F
		public vtkTemporalSnapToTimeStep(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010FBA RID: 69562
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalSnapToTimeStep_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FBB RID: 69563 RVA: 0x0017A7B0 File Offset: 0x001789B0
		public new static vtkTemporalSnapToTimeStep New()
		{
			vtkTemporalSnapToTimeStep result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FBC RID: 69564 RVA: 0x0017A804 File Offset: 0x00178A04
		public vtkTemporalSnapToTimeStep() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010FBD RID: 69565 RVA: 0x0017A848 File Offset: 0x00178A48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010FBE RID: 69566
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FBF RID: 69567 RVA: 0x0017A854 File Offset: 0x00178A54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010FC0 RID: 69568
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FC1 RID: 69569 RVA: 0x0017A874 File Offset: 0x00178A74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010FC2 RID: 69570
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalSnapToTimeStep_GetSnapMode_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FC3 RID: 69571 RVA: 0x0017A890 File Offset: 0x00178A90
		public virtual int GetSnapMode()
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_GetSnapMode_03(base.GetCppThis());
		}

		// Token: 0x06010FC4 RID: 69572
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalSnapToTimeStep_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FC5 RID: 69573 RVA: 0x0017A8B0 File Offset: 0x00178AB0
		public override int IsA(string type)
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06010FC6 RID: 69574
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalSnapToTimeStep_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FC7 RID: 69575 RVA: 0x0017A8D0 File Offset: 0x00178AD0
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_IsTypeOf_05(type);
		}

		// Token: 0x06010FC8 RID: 69576
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalSnapToTimeStep_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FC9 RID: 69577 RVA: 0x0017A8EC File Offset: 0x00178AEC
		public new vtkTemporalSnapToTimeStep NewInstance()
		{
			vtkTemporalSnapToTimeStep result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010FCA RID: 69578
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalSnapToTimeStep_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FCB RID: 69579 RVA: 0x0017A948 File Offset: 0x00178B48
		public new static vtkTemporalSnapToTimeStep SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalSnapToTimeStep vtkTemporalSnapToTimeStep = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalSnapToTimeStep = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalSnapToTimeStep.Register(null);
				}
			}
			return vtkTemporalSnapToTimeStep;
		}

		// Token: 0x06010FCC RID: 69580
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapMode_09(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FCD RID: 69581 RVA: 0x0017A9C7 File Offset: 0x00178BC7
		public virtual void SetSnapMode(int _arg)
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapMode_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06010FCE RID: 69582
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNearest_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FCF RID: 69583 RVA: 0x0017A9D7 File Offset: 0x00178BD7
		public void SetSnapModeToNearest()
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapModeToNearest_10(base.GetCppThis());
		}

		// Token: 0x06010FD0 RID: 69584
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNextAboveOrEqual_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FD1 RID: 69585 RVA: 0x0017A9E6 File Offset: 0x00178BE6
		public void SetSnapModeToNextAboveOrEqual()
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapModeToNextAboveOrEqual_11(base.GetCppThis());
		}

		// Token: 0x06010FD2 RID: 69586
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNextBelowOrEqual_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010FD3 RID: 69587 RVA: 0x0017A9F5 File Offset: 0x00178BF5
		public void SetSnapModeToNextBelowOrEqual()
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapModeToNextBelowOrEqual_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400139A RID: 5018
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalSnapToTimeStep";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400139B RID: 5019
		public new static readonly string MRClassNameKey = "class vtkTemporalSnapToTimeStep";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200061D RID: 1565
		public enum VTK_SNAP_NEAREST_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400139D RID: 5021
			VTK_SNAP_NEAREST,
			/// <summary>enum member</summary>
			// Token: 0x0400139E RID: 5022
			VTK_SNAP_NEXTABOVE_OR_EQUAL = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400139F RID: 5023
			VTK_SNAP_NEXTBELOW_OR_EQUAL = 1
		}
	}
}
