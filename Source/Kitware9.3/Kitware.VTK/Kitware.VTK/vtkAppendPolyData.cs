using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendPolyData
	/// </summary>
	/// <remarks>
	///    appends one or more polygonal datasets together
	///
	///
	/// vtkAppendPolyData is a filter that appends one of more polygonal datasets
	/// into a single polygonal dataset. All geometry is extracted and appended,
	/// but point and cell attributes (i.e., scalars, vectors, normals) are
	/// extracted and appended only if all datasets have the point and/or cell
	/// attributes available.  (For example, if one dataset has point scalars but
	/// another does not, point scalars will not be appended.)
	///
	/// @warning
	/// The related filter vtkRemovePolyData enables the subtraction, or removal
	/// of the cells of a vtkPolyData. Hence vtkRemovePolyData functions like the
	/// inverse operation to vtkAppendPolyData.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendFilter vtkRemovePolyData
	/// </seealso>
	// Token: 0x0200093A RID: 2362
	public class vtkAppendPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018754 RID: 100180 RVA: 0x00223601 File Offset: 0x00221801
		static vtkAppendPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018755 RID: 100181 RVA: 0x00223629 File Offset: 0x00221829
		public vtkAppendPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018756 RID: 100182
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018757 RID: 100183 RVA: 0x00223638 File Offset: 0x00221838
		public new static vtkAppendPolyData New()
		{
			vtkAppendPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018758 RID: 100184 RVA: 0x0022368C File Offset: 0x0022188C
		public vtkAppendPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendPolyData.vtkAppendPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018759 RID: 100185 RVA: 0x002236D0 File Offset: 0x002218D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601875A RID: 100186
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a dataset to the list of data to append. Should not be
		/// used when UserManagedInputs is true, use SetInputByNumber instead.
		/// </summary>
		// Token: 0x0601875B RID: 100187 RVA: 0x002236DC File Offset: 0x002218DC
		public void AddInputData(vtkPolyData arg0)
		{
			vtkAppendPolyData.vtkAppendPolyData_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601875C RID: 100188
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPolyData_GetInput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x0601875D RID: 100189 RVA: 0x0022370C File Offset: 0x0022190C
		public new vtkPolyData GetInput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_GetInput_02(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601875E RID: 100190
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPolyData_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x0601875F RID: 100191 RVA: 0x0022377C File Offset: 0x0022197C
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018760 RID: 100192
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendPolyData_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018761 RID: 100193 RVA: 0x002237EC File Offset: 0x002219EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018762 RID: 100194
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendPolyData_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018763 RID: 100195 RVA: 0x0022380C File Offset: 0x00221A0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018764 RID: 100196
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPolyData_GetOutputPointsPrecision_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018765 RID: 100197 RVA: 0x00223828 File Offset: 0x00221A28
		public virtual int GetOutputPointsPrecision()
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetOutputPointsPrecision_06(base.GetCppThis());
		}

		// Token: 0x06018766 RID: 100198
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPolyData_GetParallelStreaming_07(HandleRef pThis);

		/// <summary>
		/// ParallelStreaming is for a particular application.
		/// It causes this filter to ask for a different piece
		/// from each of its inputs.  If all the inputs are the same,
		/// then the output of this append filter is the whole dataset
		/// pieced back together.  Duplicate points are create
		/// along the seams.  The purpose of this feature is to get
		/// data parallelism at a course scale.  Each of the inputs
		/// can be generated in a different process at the same time.
		/// </summary>
		// Token: 0x06018767 RID: 100199 RVA: 0x00223848 File Offset: 0x00221A48
		public virtual int GetParallelStreaming()
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetParallelStreaming_07(base.GetCppThis());
		}

		// Token: 0x06018768 RID: 100200
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPolyData_GetUserManagedInputs_08(HandleRef pThis);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
		/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
		/// </summary>
		// Token: 0x06018769 RID: 100201 RVA: 0x00223868 File Offset: 0x00221A68
		public virtual int GetUserManagedInputs()
		{
			return vtkAppendPolyData.vtkAppendPolyData_GetUserManagedInputs_08(base.GetCppThis());
		}

		// Token: 0x0601876A RID: 100202
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPolyData_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601876B RID: 100203 RVA: 0x00223888 File Offset: 0x00221A88
		public override int IsA(string type)
		{
			return vtkAppendPolyData.vtkAppendPolyData_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601876C RID: 100204
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendPolyData_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601876D RID: 100205 RVA: 0x002238A8 File Offset: 0x00221AA8
		public new static int IsTypeOf(string type)
		{
			return vtkAppendPolyData.vtkAppendPolyData_IsTypeOf_10(type);
		}

		// Token: 0x0601876E RID: 100206
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPolyData_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601876F RID: 100207 RVA: 0x002238C4 File Offset: 0x00221AC4
		public new vtkAppendPolyData NewInstance()
		{
			vtkAppendPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018770 RID: 100208
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_ParallelStreamingOff_13(HandleRef pThis);

		/// <summary>
		/// ParallelStreaming is for a particular application.
		/// It causes this filter to ask for a different piece
		/// from each of its inputs.  If all the inputs are the same,
		/// then the output of this append filter is the whole dataset
		/// pieced back together.  Duplicate points are create
		/// along the seams.  The purpose of this feature is to get
		/// data parallelism at a course scale.  Each of the inputs
		/// can be generated in a different process at the same time.
		/// </summary>
		// Token: 0x06018771 RID: 100209 RVA: 0x0022391E File Offset: 0x00221B1E
		public virtual void ParallelStreamingOff()
		{
			vtkAppendPolyData.vtkAppendPolyData_ParallelStreamingOff_13(base.GetCppThis());
		}

		// Token: 0x06018772 RID: 100210
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_ParallelStreamingOn_14(HandleRef pThis);

		/// <summary>
		/// ParallelStreaming is for a particular application.
		/// It causes this filter to ask for a different piece
		/// from each of its inputs.  If all the inputs are the same,
		/// then the output of this append filter is the whole dataset
		/// pieced back together.  Duplicate points are create
		/// along the seams.  The purpose of this feature is to get
		/// data parallelism at a course scale.  Each of the inputs
		/// can be generated in a different process at the same time.
		/// </summary>
		// Token: 0x06018773 RID: 100211 RVA: 0x0022392D File Offset: 0x00221B2D
		public virtual void ParallelStreamingOn()
		{
			vtkAppendPolyData.vtkAppendPolyData_ParallelStreamingOn_14(base.GetCppThis());
		}

		// Token: 0x06018774 RID: 100212
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_RemoveInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a dataset from the list of data to append. Should not be
		/// used when UserManagedInputs is true, use SetInputByNumber (nullptr) instead.
		/// </summary>
		// Token: 0x06018775 RID: 100213 RVA: 0x0022393C File Offset: 0x00221B3C
		public void RemoveInputData(vtkPolyData arg0)
		{
			vtkAppendPolyData.vtkAppendPolyData_RemoveInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018776 RID: 100214
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendPolyData_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018777 RID: 100215 RVA: 0x0022396C File Offset: 0x00221B6C
		public new static vtkAppendPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkAppendPolyData vtkAppendPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendPolyData.vtkAppendPolyData_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendPolyData = (vtkAppendPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendPolyData.Register(null);
				}
			}
			return vtkAppendPolyData;
		}

		// Token: 0x06018778 RID: 100216
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_SetInputConnectionByNumber_17(HandleRef pThis, int num, HandleRef input);

		/// <summary>
		/// Directly set(allocate) number of inputs, should only be used
		/// when UserManagedInputs is true.
		/// </summary>
		// Token: 0x06018779 RID: 100217 RVA: 0x002239EC File Offset: 0x00221BEC
		public void SetInputConnectionByNumber(int num, vtkAlgorithmOutput input)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetInputConnectionByNumber_17(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601877A RID: 100218
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_SetInputDataByNumber_18(HandleRef pThis, int num, HandleRef ds);

		/// <summary>
		/// Directly set(allocate) number of inputs, should only be used
		/// when UserManagedInputs is true.
		/// </summary>
		// Token: 0x0601877B RID: 100219 RVA: 0x00223A1C File Offset: 0x00221C1C
		public void SetInputDataByNumber(int num, vtkPolyData ds)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetInputDataByNumber_18(base.GetCppThis(), num, (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601877C RID: 100220
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_SetNumberOfInputs_19(HandleRef pThis, int num);

		/// <summary>
		/// Directly set(allocate) number of inputs, should only be used
		/// when UserManagedInputs is true.
		/// </summary>
		// Token: 0x0601877D RID: 100221 RVA: 0x00223A4C File Offset: 0x00221C4C
		public void SetNumberOfInputs(int num)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetNumberOfInputs_19(base.GetCppThis(), num);
		}

		// Token: 0x0601877E RID: 100222
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_SetOutputPointsPrecision_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0601877F RID: 100223 RVA: 0x00223A5C File Offset: 0x00221C5C
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetOutputPointsPrecision_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06018780 RID: 100224
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_SetParallelStreaming_21(HandleRef pThis, int _arg);

		/// <summary>
		/// ParallelStreaming is for a particular application.
		/// It causes this filter to ask for a different piece
		/// from each of its inputs.  If all the inputs are the same,
		/// then the output of this append filter is the whole dataset
		/// pieced back together.  Duplicate points are create
		/// along the seams.  The purpose of this feature is to get
		/// data parallelism at a course scale.  Each of the inputs
		/// can be generated in a different process at the same time.
		/// </summary>
		// Token: 0x06018781 RID: 100225 RVA: 0x00223A6C File Offset: 0x00221C6C
		public virtual void SetParallelStreaming(int _arg)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetParallelStreaming_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06018782 RID: 100226
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_SetUserManagedInputs_22(HandleRef pThis, int _arg);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
		/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
		/// </summary>
		// Token: 0x06018783 RID: 100227 RVA: 0x00223A7C File Offset: 0x00221C7C
		public virtual void SetUserManagedInputs(int _arg)
		{
			vtkAppendPolyData.vtkAppendPolyData_SetUserManagedInputs_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06018784 RID: 100228
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_UserManagedInputsOff_23(HandleRef pThis);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
		/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
		/// </summary>
		// Token: 0x06018785 RID: 100229 RVA: 0x00223A8C File Offset: 0x00221C8C
		public virtual void UserManagedInputsOff()
		{
			vtkAppendPolyData.vtkAppendPolyData_UserManagedInputsOff_23(base.GetCppThis());
		}

		// Token: 0x06018786 RID: 100230
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendPolyData_UserManagedInputsOn_24(HandleRef pThis);

		/// <summary>
		/// UserManagedInputs allows the user to set inputs by number instead of
		/// using the AddInput/RemoveInput functions. Calls to
		/// SetNumberOfInputs/SetInputConnectionByNumber should not be mixed with calls
		/// to AddInput/RemoveInput. By default, UserManagedInputs is false.
		/// </summary>
		// Token: 0x06018787 RID: 100231 RVA: 0x00223A9B File Offset: 0x00221C9B
		public virtual void UserManagedInputsOn()
		{
			vtkAppendPolyData.vtkAppendPolyData_UserManagedInputsOn_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B1E RID: 6942
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B1F RID: 6943
		public new static readonly string MRClassNameKey = "class vtkAppendPolyData";
	}
}
