using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only vtkTables as output
	///
	///
	/// vtkTableAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be Tree. If that
	/// isn't the case then please override this method in your subclass.
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie for creating this class.
	/// </remarks>
	// Token: 0x0200012D RID: 301
	public class vtkTableAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003CAF RID: 15535 RVA: 0x000589AB File Offset: 0x00056BAB
		static vtkTableAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003CB0 RID: 15536 RVA: 0x000589D3 File Offset: 0x00056BD3
		public vtkTableAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003CB1 RID: 15537
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CB2 RID: 15538 RVA: 0x000589E4 File Offset: 0x00056BE4
		public new static vtkTableAlgorithm New()
		{
			vtkTableAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableAlgorithm.vtkTableAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CB3 RID: 15539 RVA: 0x00058A38 File Offset: 0x00056C38
		public vtkTableAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableAlgorithm.vtkTableAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003CB4 RID: 15540 RVA: 0x00058A7C File Offset: 0x00056C7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003CB5 RID: 15541
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CB6 RID: 15542 RVA: 0x00058A88 File Offset: 0x00056C88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableAlgorithm.vtkTableAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003CB7 RID: 15543
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CB8 RID: 15544 RVA: 0x00058AA8 File Offset: 0x00056CA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableAlgorithm.vtkTableAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003CB9 RID: 15545
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003CBA RID: 15546 RVA: 0x00058AC4 File Offset: 0x00056CC4
		public vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableAlgorithm.vtkTableAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003CBB RID: 15547
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003CBC RID: 15548 RVA: 0x00058B34 File Offset: 0x00056D34
		public vtkTable GetOutput(int index)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableAlgorithm.vtkTableAlgorithm_GetOutput_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003CBD RID: 15549
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CBE RID: 15550 RVA: 0x00058BA4 File Offset: 0x00056DA4
		public override int IsA(string type)
		{
			return vtkTableAlgorithm.vtkTableAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003CBF RID: 15551
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CC0 RID: 15552 RVA: 0x00058BC4 File Offset: 0x00056DC4
		public new static int IsTypeOf(string type)
		{
			return vtkTableAlgorithm.vtkTableAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06003CC1 RID: 15553
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CC2 RID: 15554 RVA: 0x00058BE0 File Offset: 0x00056DE0
		public new vtkTableAlgorithm NewInstance()
		{
			vtkTableAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableAlgorithm.vtkTableAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003CC3 RID: 15555
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CC4 RID: 15556 RVA: 0x00058C3C File Offset: 0x00056E3C
		public new static vtkTableAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkTableAlgorithm vtkTableAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableAlgorithm.vtkTableAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableAlgorithm = (vtkTableAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableAlgorithm.Register(null);
				}
			}
			return vtkTableAlgorithm;
		}

		// Token: 0x06003CC5 RID: 15557
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003CC6 RID: 15558 RVA: 0x00058CBC File Offset: 0x00056EBC
		public void SetInputData(vtkDataObject obj)
		{
			vtkTableAlgorithm.vtkTableAlgorithm_SetInputData_10(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06003CC7 RID: 15559
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003CC8 RID: 15560 RVA: 0x00058CEC File Offset: 0x00056EEC
		public void SetInputData(int index, vtkDataObject obj)
		{
			vtkTableAlgorithm.vtkTableAlgorithm_SetInputData_11(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000693 RID: 1683
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000694 RID: 1684
		public new static readonly string MRClassNameKey = "class vtkTableAlgorithm";
	}
}
