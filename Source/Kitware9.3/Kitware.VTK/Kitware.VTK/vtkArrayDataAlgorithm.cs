using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayDataAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce
	/// vtkArrayDatas as output
	///
	///
	/// vtkArrayDataAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be vtkArrayData. If that
	/// isn't the case then please override this method in your subclass.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000671 RID: 1649
	public class vtkArrayDataAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011C95 RID: 72853 RVA: 0x0018E18F File Offset: 0x0018C38F
		static vtkArrayDataAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayDataAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayDataAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011C96 RID: 72854 RVA: 0x0018E1B7 File Offset: 0x0018C3B7
		public vtkArrayDataAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011C97 RID: 72855
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C98 RID: 72856 RVA: 0x0018E1C8 File Offset: 0x0018C3C8
		public new static vtkArrayDataAlgorithm New()
		{
			vtkArrayDataAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C99 RID: 72857 RVA: 0x0018E21C File Offset: 0x0018C41C
		public vtkArrayDataAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011C9A RID: 72858 RVA: 0x0018E260 File Offset: 0x0018C460
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011C9B RID: 72859
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayDataAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C9C RID: 72860 RVA: 0x0018E26C File Offset: 0x0018C46C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011C9D RID: 72861
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayDataAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011C9E RID: 72862 RVA: 0x0018E28C File Offset: 0x0018C48C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011C9F RID: 72863
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06011CA0 RID: 72864 RVA: 0x0018E2A8 File Offset: 0x0018C4A8
		public vtkArrayData GetOutput()
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		// Token: 0x06011CA1 RID: 72865
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06011CA2 RID: 72866 RVA: 0x0018E318 File Offset: 0x0018C518
		public vtkArrayData GetOutput(int index)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_GetOutput_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		// Token: 0x06011CA3 RID: 72867
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CA4 RID: 72868 RVA: 0x0018E388 File Offset: 0x0018C588
		public override int IsA(string type)
		{
			return vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06011CA5 RID: 72869
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CA6 RID: 72870 RVA: 0x0018E3A8 File Offset: 0x0018C5A8
		public new static int IsTypeOf(string type)
		{
			return vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06011CA7 RID: 72871
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CA8 RID: 72872 RVA: 0x0018E3C4 File Offset: 0x0018C5C4
		public new vtkArrayDataAlgorithm NewInstance()
		{
			vtkArrayDataAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011CA9 RID: 72873
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CAA RID: 72874 RVA: 0x0018E420 File Offset: 0x0018C620
		public new static vtkArrayDataAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkArrayDataAlgorithm vtkArrayDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayDataAlgorithm = (vtkArrayDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayDataAlgorithm.Register(null);
				}
			}
			return vtkArrayDataAlgorithm;
		}

		// Token: 0x06011CAB RID: 72875
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06011CAC RID: 72876 RVA: 0x0018E4A0 File Offset: 0x0018C6A0
		public void SetInputData(vtkDataObject obj)
		{
			vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_SetInputData_10(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06011CAD RID: 72877
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06011CAE RID: 72878 RVA: 0x0018E4D0 File Offset: 0x0018C6D0
		public void SetInputData(int index, vtkDataObject obj)
		{
			vtkArrayDataAlgorithm.vtkArrayDataAlgorithm_SetInputData_11(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001483 RID: 5251
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayDataAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001484 RID: 5252
		public new static readonly string MRClassNameKey = "class vtkArrayDataAlgorithm";
	}
}
