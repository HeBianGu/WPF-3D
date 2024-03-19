using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPiecewiseFunctionAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only piecewise function as output
	///
	///
	/// vtkPiecewiseFunctionAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be PiecewiseFunction. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	/// </remarks>
	// Token: 0x020009DE RID: 2526
	public class vtkPiecewiseFunctionAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A4A4 RID: 107684 RVA: 0x00247D21 File Offset: 0x00245F21
		static vtkPiecewiseFunctionAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunctionAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunctionAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A4A5 RID: 107685 RVA: 0x00247D49 File Offset: 0x00245F49
		public vtkPiecewiseFunctionAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A4A6 RID: 107686
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4A7 RID: 107687 RVA: 0x00247D58 File Offset: 0x00245F58
		public new static vtkPiecewiseFunctionAlgorithm New()
		{
			vtkPiecewiseFunctionAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4A8 RID: 107688 RVA: 0x00247DAC File Offset: 0x00245FAC
		public vtkPiecewiseFunctionAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A4A9 RID: 107689 RVA: 0x00247DF0 File Offset: 0x00245FF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A4AA RID: 107690
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0601A4AB RID: 107691 RVA: 0x00247DFC File Offset: 0x00245FFC
		public void AddInputData(vtkDataObject arg0)
		{
			vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A4AC RID: 107692
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0601A4AD RID: 107693 RVA: 0x00247E2C File Offset: 0x0024602C
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601A4AE RID: 107694
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0601A4AF RID: 107695 RVA: 0x00247E5C File Offset: 0x0024605C
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601A4B0 RID: 107696
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0601A4B1 RID: 107697 RVA: 0x00247ECC File Offset: 0x002460CC
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601A4B2 RID: 107698
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunctionAlgorithm_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4B3 RID: 107699 RVA: 0x00247F3C File Offset: 0x0024613C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A4B4 RID: 107700
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunctionAlgorithm_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4B5 RID: 107701 RVA: 0x00247F5C File Offset: 0x0024615C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601A4B6 RID: 107702
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_GetOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0601A4B7 RID: 107703 RVA: 0x00247F78 File Offset: 0x00246178
		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_GetOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601A4B8 RID: 107704
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_GetOutput_08(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0601A4B9 RID: 107705 RVA: 0x00247FE8 File Offset: 0x002461E8
		public vtkDataObject GetOutput(int arg0)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_GetOutput_08(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601A4BA RID: 107706
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunctionAlgorithm_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4BB RID: 107707 RVA: 0x00248058 File Offset: 0x00246258
		public override int IsA(string type)
		{
			return vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601A4BC RID: 107708
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunctionAlgorithm_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4BD RID: 107709 RVA: 0x00248078 File Offset: 0x00246278
		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_IsTypeOf_10(type);
		}

		// Token: 0x0601A4BE RID: 107710
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4BF RID: 107711 RVA: 0x00248094 File Offset: 0x00246294
		public new vtkPiecewiseFunctionAlgorithm NewInstance()
		{
			vtkPiecewiseFunctionAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunctionAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A4C0 RID: 107712
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunctionAlgorithm_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4C1 RID: 107713 RVA: 0x002480F0 File Offset: 0x002462F0
		public new static vtkPiecewiseFunctionAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunctionAlgorithm vtkPiecewiseFunctionAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunctionAlgorithm = (vtkPiecewiseFunctionAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunctionAlgorithm.Register(null);
				}
			}
			return vtkPiecewiseFunctionAlgorithm;
		}

		// Token: 0x0601A4C2 RID: 107714
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionAlgorithm_SetInputData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0601A4C3 RID: 107715 RVA: 0x00248170 File Offset: 0x00246370
		public void SetInputData(vtkDataObject arg0)
		{
			vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_SetInputData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A4C4 RID: 107716
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionAlgorithm_SetInputData_15(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0601A4C5 RID: 107717 RVA: 0x002481A0 File Offset: 0x002463A0
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_SetInputData_15(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601A4C6 RID: 107718
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunctionAlgorithm_SetOutput_16(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0601A4C7 RID: 107719 RVA: 0x002481D0 File Offset: 0x002463D0
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkPiecewiseFunctionAlgorithm.vtkPiecewiseFunctionAlgorithm_SetOutput_16(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C8C RID: 7308
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunctionAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C8D RID: 7309
		public new static readonly string MRClassNameKey = "class vtkPiecewiseFunctionAlgorithm";
	}
}
