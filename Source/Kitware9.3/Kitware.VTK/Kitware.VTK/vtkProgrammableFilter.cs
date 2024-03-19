using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgrammableFilter
	/// </summary>
	/// <remarks>
	///    a user-programmable filter
	///
	/// vtkProgrammableFilter is a filter that can be programmed by the user.  To
	/// use the filter you define a function that retrieves input of the correct
	/// type, creates data, and then manipulates the output of the filter.  Using
	/// this filter avoids the need for subclassing - and the function can be
	/// defined in an interpreter wrapper language such as Java.
	///
	/// The trickiest part of using this filter is that the input and output
	/// methods are unusual and cannot be compile-time type checked. Instead, as a
	/// user of this filter it is your responsibility to set and get the correct
	/// input and output types.
	///
	/// @warning
	/// The filter correctly manages modified time and network execution in most
	/// cases. However, if you change the definition of the filter function,
	/// you'll want to send a manual Modified() method to the filter to force it
	/// to reexecute.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProgrammablePointDataFilter vtkProgrammableSource
	/// </seealso>
	// Token: 0x0200042F RID: 1071
	public class vtkProgrammableFilter : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C8A0 RID: 51360 RVA: 0x001175AE File Offset: 0x001157AE
		static vtkProgrammableFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C8A1 RID: 51361 RVA: 0x001175D6 File Offset: 0x001157D6
		public vtkProgrammableFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C8A2 RID: 51362
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8A3 RID: 51363 RVA: 0x001175E4 File Offset: 0x001157E4
		public new static vtkProgrammableFilter New()
		{
			vtkProgrammableFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8A4 RID: 51364 RVA: 0x00117638 File Offset: 0x00115838
		public vtkProgrammableFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgrammableFilter.vtkProgrammableFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C8A5 RID: 51365 RVA: 0x0011767C File Offset: 0x0011587C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C8A6 RID: 51366
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableFilter_CopyArraysOff_01(HandleRef pThis);

		/// <summary>
		/// When CopyArrays is true, all arrays are copied to the output
		/// iff input and output are of the same type. False by default.
		/// </summary>
		// Token: 0x0600C8A7 RID: 51367 RVA: 0x00117687 File Offset: 0x00115887
		public virtual void CopyArraysOff()
		{
			vtkProgrammableFilter.vtkProgrammableFilter_CopyArraysOff_01(base.GetCppThis());
		}

		// Token: 0x0600C8A8 RID: 51368
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableFilter_CopyArraysOn_02(HandleRef pThis);

		/// <summary>
		/// When CopyArrays is true, all arrays are copied to the output
		/// iff input and output are of the same type. False by default.
		/// </summary>
		// Token: 0x0600C8A9 RID: 51369 RVA: 0x00117696 File Offset: 0x00115896
		public virtual void CopyArraysOn()
		{
			vtkProgrammableFilter.vtkProgrammableFilter_CopyArraysOn_02(base.GetCppThis());
		}

		// Token: 0x0600C8AA RID: 51370
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProgrammableFilter_GetCopyArrays_03(HandleRef pThis);

		/// <summary>
		/// When CopyArrays is true, all arrays are copied to the output
		/// iff input and output are of the same type. False by default.
		/// </summary>
		// Token: 0x0600C8AB RID: 51371 RVA: 0x001176A8 File Offset: 0x001158A8
		public virtual bool GetCopyArrays()
		{
			return vtkProgrammableFilter.vtkProgrammableFilter_GetCopyArrays_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C8AC RID: 51372
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetGraphInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8AD RID: 51373 RVA: 0x001176D0 File Offset: 0x001158D0
		public vtkGraph GetGraphInput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetGraphInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0600C8AE RID: 51374
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetMoleculeInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8AF RID: 51375 RVA: 0x00117740 File Offset: 0x00115940
		public vtkMolecule GetMoleculeInput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetMoleculeInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x0600C8B0 RID: 51376
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8B1 RID: 51377 RVA: 0x001177B0 File Offset: 0x001159B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgrammableFilter.vtkProgrammableFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C8B2 RID: 51378
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8B3 RID: 51379 RVA: 0x001177D0 File Offset: 0x001159D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgrammableFilter.vtkProgrammableFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600C8B4 RID: 51380
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetPolyDataInput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8B5 RID: 51381 RVA: 0x001177EC File Offset: 0x001159EC
		public vtkPolyData GetPolyDataInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetPolyDataInput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600C8B6 RID: 51382
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetRectilinearGridInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8B7 RID: 51383 RVA: 0x0011785C File Offset: 0x00115A5C
		public vtkRectilinearGrid GetRectilinearGridInput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetRectilinearGridInput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x0600C8B8 RID: 51384
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetStructuredGridInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8B9 RID: 51385 RVA: 0x001178CC File Offset: 0x00115ACC
		public vtkStructuredGrid GetStructuredGridInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetStructuredGridInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0600C8BA RID: 51386
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetStructuredPointsInput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8BB RID: 51387 RVA: 0x0011793C File Offset: 0x00115B3C
		public vtkStructuredPoints GetStructuredPointsInput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetStructuredPointsInput_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x0600C8BC RID: 51388
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetTableInput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8BD RID: 51389 RVA: 0x001179AC File Offset: 0x00115BAC
		public vtkTable GetTableInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetTableInput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x0600C8BE RID: 51390
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_GetUnstructuredGridInput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input as a concrete type. This method is typically used by the
		/// writer of the filter function to get the input as a particular type (i.e.,
		/// it essentially does type casting). It is the users responsibility to know
		/// the correct type of the input data.
		/// </summary>
		// Token: 0x0600C8BF RID: 51391 RVA: 0x00117A1C File Offset: 0x00115C1C
		public vtkUnstructuredGrid GetUnstructuredGridInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_GetUnstructuredGridInput_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0600C8C0 RID: 51392
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableFilter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8C1 RID: 51393 RVA: 0x00117A8C File Offset: 0x00115C8C
		public override int IsA(string type)
		{
			return vtkProgrammableFilter.vtkProgrammableFilter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600C8C2 RID: 51394
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableFilter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8C3 RID: 51395 RVA: 0x00117AAC File Offset: 0x00115CAC
		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableFilter.vtkProgrammableFilter_IsTypeOf_15(type);
		}

		// Token: 0x0600C8C4 RID: 51396
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8C5 RID: 51397 RVA: 0x00117AC8 File Offset: 0x00115CC8
		public new vtkProgrammableFilter NewInstance()
		{
			vtkProgrammableFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C8C6 RID: 51398
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8C7 RID: 51399 RVA: 0x00117B24 File Offset: 0x00115D24
		public new static vtkProgrammableFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableFilter vtkProgrammableFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableFilter.vtkProgrammableFilter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableFilter = (vtkProgrammableFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableFilter.Register(null);
				}
			}
			return vtkProgrammableFilter;
		}

		// Token: 0x0600C8C8 RID: 51400
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableFilter_SetCopyArrays_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// When CopyArrays is true, all arrays are copied to the output
		/// iff input and output are of the same type. False by default.
		/// </summary>
		// Token: 0x0600C8C9 RID: 51401 RVA: 0x00117BA3 File Offset: 0x00115DA3
		public virtual void SetCopyArrays(bool _arg)
		{
			vtkProgrammableFilter.vtkProgrammableFilter_SetCopyArrays_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C8CA RID: 51402
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableFilter_SetExecuteMethod_20(HandleRef pThis, vtkProgrammableFilter.ProgrammableMethodCallbackType f, IntPtr arg);

		/// <summary>
		/// Specify the function to use to operate on the point attribute data. Note
		/// that the function takes a single (void *) argument.
		/// </summary>
		// Token: 0x0600C8CB RID: 51403 RVA: 0x00117BBB File Offset: 0x00115DBB
		public void SetExecuteMethod(vtkProgrammableFilter.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableFilter.vtkProgrammableFilter_SetExecuteMethod_20(base.GetCppThis(), f, arg);
		}

		// Token: 0x0600C8CC RID: 51404
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableFilter_SetExecuteMethodArgDelete_21(HandleRef pThis, vtkProgrammableFilter.ProgrammableMethodCallbackType f);

		/// <summary>
		/// Set the arg delete method. This is used to free user memory.
		/// </summary>
		// Token: 0x0600C8CD RID: 51405 RVA: 0x00117BCC File Offset: 0x00115DCC
		public void SetExecuteMethodArgDelete(vtkProgrammableFilter.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableFilter.vtkProgrammableFilter_SetExecuteMethodArgDelete_21(base.GetCppThis(), f);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EEB RID: 3819
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EEC RID: 3820
		public new static readonly string MRClassNameKey = "class vtkProgrammableFilter";

		/// <summary>
		/// Signature definition for programmable method callbacks. Methods passed to
		/// SetExecuteMethod or SetExecuteMethodArgDelete must conform to this
		/// signature.
		/// The presence of this typedef is useful for reference and for external
		/// analysis tools, but it cannot be used in the method signatures in these
		/// header files themselves because it prevents the internal VTK wrapper
		/// generators from wrapping these methods.
		/// </summary>
		// Token: 0x02000430 RID: 1072
		// (Invoke) Token: 0x0600C8CF RID: 51407
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);
	}
}
