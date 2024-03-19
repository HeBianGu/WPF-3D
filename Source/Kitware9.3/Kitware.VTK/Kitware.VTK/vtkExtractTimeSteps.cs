using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractTimeSteps
	/// </summary>
	/// <remarks>
	///    extract specific time-steps from dataset
	///
	/// vtkExtractTimeSteps extracts the specified time steps from the input dataset.
	/// It has two modes, one to specify timesteps explicitly by their indices and one
	/// to specify a range of timesteps to extract.
	///
	/// When specifying timesteps explicitly the timesteps to be extracted are
	/// specified by their indices. If no time step is specified, all of the input
	/// time steps are extracted.
	///
	/// When specifying a range, the beginning and end times are specified and the
	/// timesteps in between are extracted.  This can be modified by the TimeStepInterval
	/// property that sets the filter to extract every Nth timestep.
	///
	/// This filter is useful when one wants to work with only a sub-set of the input
	/// time steps.
	/// </remarks>
	// Token: 0x020006BA RID: 1722
	public class vtkExtractTimeSteps : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012625 RID: 75301 RVA: 0x0019C10E File Offset: 0x0019A30E
		static vtkExtractTimeSteps()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractTimeSteps.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractTimeSteps"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012626 RID: 75302 RVA: 0x0019C136 File Offset: 0x0019A336
		public vtkExtractTimeSteps(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012627 RID: 75303
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTimeSteps_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012628 RID: 75304 RVA: 0x0019C144 File Offset: 0x0019A344
		public new static vtkExtractTimeSteps New()
		{
			vtkExtractTimeSteps result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractTimeSteps.vtkExtractTimeSteps_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTimeSteps)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012629 RID: 75305 RVA: 0x0019C198 File Offset: 0x0019A398
		public vtkExtractTimeSteps() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractTimeSteps.vtkExtractTimeSteps_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601262A RID: 75306 RVA: 0x0019C1DC File Offset: 0x0019A3DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601262B RID: 75307
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_AddTimeStepIndex_01(HandleRef pThis, int timeStepIndex);

		/// <summary>
		/// Add a time step index. Not added if the index already exists.
		/// </summary>
		// Token: 0x0601262C RID: 75308 RVA: 0x0019C1E7 File Offset: 0x0019A3E7
		public void AddTimeStepIndex(int timeStepIndex)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_AddTimeStepIndex_01(base.GetCppThis(), timeStepIndex);
		}

		// Token: 0x0601262D RID: 75309
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_ClearTimeStepIndices_02(HandleRef pThis);

		/// <summary>
		/// Clear the time step indices
		/// </summary>
		// Token: 0x0601262E RID: 75310 RVA: 0x0019C1F7 File Offset: 0x0019A3F7
		public void ClearTimeStepIndices()
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_ClearTimeStepIndices_02(base.GetCppThis());
		}

		// Token: 0x0601262F RID: 75311
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_GenerateTimeStepIndices_03(HandleRef pThis, int begin, int end, int step);

		/// <summary>
		/// Generate a range of indices in [begin, end) with a step size of 'step'
		/// </summary>
		// Token: 0x06012630 RID: 75312 RVA: 0x0019C206 File Offset: 0x0019A406
		public void GenerateTimeStepIndices(int begin, int end, int step)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_GenerateTimeStepIndices_03(base.GetCppThis(), begin, end, step);
		}

		// Token: 0x06012631 RID: 75313
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractTimeSteps_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012632 RID: 75314 RVA: 0x0019C218 File Offset: 0x0019A418
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06012633 RID: 75315
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractTimeSteps_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012634 RID: 75316 RVA: 0x0019C238 File Offset: 0x0019A438
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06012635 RID: 75317
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_GetNumberOfTimeSteps_06(HandleRef pThis);

		/// <summary>
		/// Get the number of time steps that will be extracted
		/// </summary>
		// Token: 0x06012636 RID: 75318 RVA: 0x0019C254 File Offset: 0x0019A454
		public int GetNumberOfTimeSteps()
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetNumberOfTimeSteps_06(base.GetCppThis());
		}

		// Token: 0x06012637 RID: 75319
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTimeSteps_GetRange_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the range of time steps to extract.
		/// </summary>
		// Token: 0x06012638 RID: 75320 RVA: 0x0019C274 File Offset: 0x0019A474
		public virtual int[] GetRange()
		{
			IntPtr intPtr = vtkExtractTimeSteps.vtkExtractTimeSteps_GetRange_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06012639 RID: 75321
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_GetRange_08(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the range of time steps to extract.
		/// </summary>
		// Token: 0x0601263A RID: 75322 RVA: 0x0019C2BC File Offset: 0x0019A4BC
		public virtual void GetRange(ref int _arg1, ref int _arg2)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_GetRange_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0601263B RID: 75323
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_GetRange_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the range of time steps to extract.
		/// </summary>
		// Token: 0x0601263C RID: 75324 RVA: 0x0019C2CD File Offset: 0x0019A4CD
		public virtual void GetRange(IntPtr _arg)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_GetRange_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0601263D RID: 75325
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_GetTimeEstimationMode_10(HandleRef pThis);

		/// <summary>
		/// Get/Set what to do when the requested time is not one of the timesteps this filter
		/// is set to extract.  Should be one of the values of the enum
		/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
		/// </summary>
		// Token: 0x0601263E RID: 75326 RVA: 0x0019C2E0 File Offset: 0x0019A4E0
		public virtual int GetTimeEstimationMode()
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetTimeEstimationMode_10(base.GetCppThis());
		}

		// Token: 0x0601263F RID: 75327
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_GetTimeStepIndices_11(HandleRef pThis, IntPtr timeStepIndices);

		/// <summary>
		/// Get/Set an array of time step indices. For the Get function,
		/// timeStepIndices should be big enough for GetNumberOfTimeSteps() values.
		/// </summary>
		// Token: 0x06012640 RID: 75328 RVA: 0x0019C2FF File Offset: 0x0019A4FF
		public void GetTimeStepIndices(IntPtr timeStepIndices)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_GetTimeStepIndices_11(base.GetCppThis(), timeStepIndices);
		}

		// Token: 0x06012641 RID: 75329
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_GetTimeStepInterval_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the time step interval to extract.  This is the N in 'extract every
		/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
		/// </summary>
		// Token: 0x06012642 RID: 75330 RVA: 0x0019C310 File Offset: 0x0019A510
		public virtual int GetTimeStepInterval()
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetTimeStepInterval_12(base.GetCppThis());
		}

		// Token: 0x06012643 RID: 75331
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_GetTimeStepIntervalMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the time step interval to extract.  This is the N in 'extract every
		/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
		/// </summary>
		// Token: 0x06012644 RID: 75332 RVA: 0x0019C330 File Offset: 0x0019A530
		public virtual int GetTimeStepIntervalMaxValue()
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetTimeStepIntervalMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06012645 RID: 75333
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_GetTimeStepIntervalMinValue_14(HandleRef pThis);

		/// <summary>
		/// Get/Set the time step interval to extract.  This is the N in 'extract every
		/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
		/// </summary>
		// Token: 0x06012646 RID: 75334 RVA: 0x0019C350 File Offset: 0x0019A550
		public virtual int GetTimeStepIntervalMinValue()
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetTimeStepIntervalMinValue_14(base.GetCppThis());
		}

		// Token: 0x06012647 RID: 75335
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractTimeSteps_GetUseRange_15(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to extract a range of timesteps.  When false, extracts
		/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
		/// </summary>
		// Token: 0x06012648 RID: 75336 RVA: 0x0019C370 File Offset: 0x0019A570
		public virtual bool GetUseRange()
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_GetUseRange_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06012649 RID: 75337
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601264A RID: 75338 RVA: 0x0019C398 File Offset: 0x0019A598
		public override int IsA(string type)
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601264B RID: 75339
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTimeSteps_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601264C RID: 75340 RVA: 0x0019C3B8 File Offset: 0x0019A5B8
		public new static int IsTypeOf(string type)
		{
			return vtkExtractTimeSteps.vtkExtractTimeSteps_IsTypeOf_17(type);
		}

		// Token: 0x0601264D RID: 75341
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTimeSteps_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601264E RID: 75342 RVA: 0x0019C3D4 File Offset: 0x0019A5D4
		public new vtkExtractTimeSteps NewInstance()
		{
			vtkExtractTimeSteps result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractTimeSteps.vtkExtractTimeSteps_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTimeSteps)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601264F RID: 75343
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTimeSteps_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012650 RID: 75344 RVA: 0x0019C430 File Offset: 0x0019A630
		public new static vtkExtractTimeSteps SafeDownCast(vtkObjectBase o)
		{
			vtkExtractTimeSteps vtkExtractTimeSteps = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractTimeSteps.vtkExtractTimeSteps_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractTimeSteps = (vtkExtractTimeSteps)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractTimeSteps.Register(null);
				}
			}
			return vtkExtractTimeSteps;
		}

		// Token: 0x06012651 RID: 75345
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetRange_21(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the range of time steps to extract.
		/// </summary>
		// Token: 0x06012652 RID: 75346 RVA: 0x0019C4AF File Offset: 0x0019A6AF
		public virtual void SetRange(int _arg1, int _arg2)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetRange_21(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06012653 RID: 75347
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetRange_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the range of time steps to extract.
		/// </summary>
		// Token: 0x06012654 RID: 75348 RVA: 0x0019C4C0 File Offset: 0x0019A6C0
		public void SetRange(IntPtr _arg)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetRange_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06012655 RID: 75349
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetTimeEstimationMode_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set what to do when the requested time is not one of the timesteps this filter
		/// is set to extract.  Should be one of the values of the enum
		/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
		/// </summary>
		// Token: 0x06012656 RID: 75350 RVA: 0x0019C4D0 File Offset: 0x0019A6D0
		public virtual void SetTimeEstimationMode(int _arg)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetTimeEstimationMode_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06012657 RID: 75351
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetTimeEstimationModeToNearest_24(HandleRef pThis);

		/// <summary>
		/// Get/Set what to do when the requested time is not one of the timesteps this filter
		/// is set to extract.  Should be one of the values of the enum
		/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
		/// </summary>
		// Token: 0x06012658 RID: 75352 RVA: 0x0019C4E0 File Offset: 0x0019A6E0
		public void SetTimeEstimationModeToNearest()
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetTimeEstimationModeToNearest_24(base.GetCppThis());
		}

		// Token: 0x06012659 RID: 75353
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetTimeEstimationModeToNext_25(HandleRef pThis);

		/// <summary>
		/// Get/Set what to do when the requested time is not one of the timesteps this filter
		/// is set to extract.  Should be one of the values of the enum
		/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
		/// </summary>
		// Token: 0x0601265A RID: 75354 RVA: 0x0019C4EF File Offset: 0x0019A6EF
		public void SetTimeEstimationModeToNext()
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetTimeEstimationModeToNext_25(base.GetCppThis());
		}

		// Token: 0x0601265B RID: 75355
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetTimeEstimationModeToPrevious_26(HandleRef pThis);

		/// <summary>
		/// Get/Set what to do when the requested time is not one of the timesteps this filter
		/// is set to extract.  Should be one of the values of the enum
		/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
		/// </summary>
		// Token: 0x0601265C RID: 75356 RVA: 0x0019C4FE File Offset: 0x0019A6FE
		public void SetTimeEstimationModeToPrevious()
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetTimeEstimationModeToPrevious_26(base.GetCppThis());
		}

		// Token: 0x0601265D RID: 75357
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetTimeStepIndices_27(HandleRef pThis, int count, IntPtr timeStepIndices);

		/// <summary>
		/// Get/Set an array of time step indices. For the Get function,
		/// timeStepIndices should be big enough for GetNumberOfTimeSteps() values.
		/// </summary>
		// Token: 0x0601265E RID: 75358 RVA: 0x0019C50D File Offset: 0x0019A70D
		public void SetTimeStepIndices(int count, IntPtr timeStepIndices)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetTimeStepIndices_27(base.GetCppThis(), count, timeStepIndices);
		}

		// Token: 0x0601265F RID: 75359
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetTimeStepInterval_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the time step interval to extract.  This is the N in 'extract every
		/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
		/// </summary>
		// Token: 0x06012660 RID: 75360 RVA: 0x0019C51E File Offset: 0x0019A71E
		public virtual void SetTimeStepInterval(int _arg)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetTimeStepInterval_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06012661 RID: 75361
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_SetUseRange_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether to extract a range of timesteps.  When false, extracts
		/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
		/// </summary>
		// Token: 0x06012662 RID: 75362 RVA: 0x0019C52E File Offset: 0x0019A72E
		public virtual void SetUseRange(bool _arg)
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_SetUseRange_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012663 RID: 75363
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_UseRangeOff_30(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to extract a range of timesteps.  When false, extracts
		/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
		/// </summary>
		// Token: 0x06012664 RID: 75364 RVA: 0x0019C546 File Offset: 0x0019A746
		public virtual void UseRangeOff()
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_UseRangeOff_30(base.GetCppThis());
		}

		// Token: 0x06012665 RID: 75365
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTimeSteps_UseRangeOn_31(HandleRef pThis);

		/// <summary>
		/// Get/Set whether to extract a range of timesteps.  When false, extracts
		/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
		/// </summary>
		// Token: 0x06012666 RID: 75366 RVA: 0x0019C555 File Offset: 0x0019A755
		public virtual void UseRangeOn()
		{
			vtkExtractTimeSteps.vtkExtractTimeSteps_UseRangeOn_31(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001522 RID: 5410
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractTimeSteps";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001523 RID: 5411
		public new static readonly string MRClassNameKey = "class vtkExtractTimeSteps";

		/// <summary>
		/// Get/Set the time step interval to extract.  This is the N in 'extract every
		/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
		/// </summary>
		// Token: 0x020006BB RID: 1723
		public enum NEAREST_TIMESTEP_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001525 RID: 5413
			NEAREST_TIMESTEP = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001526 RID: 5414
			NEXT_TIMESTEP = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001527 RID: 5415
			PREVIOUS_TIMESTEP = 0
		}
	}
}
