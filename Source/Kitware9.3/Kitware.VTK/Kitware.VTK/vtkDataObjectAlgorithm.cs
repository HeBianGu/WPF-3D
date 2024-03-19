using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only data object as output
	///
	///
	/// vtkDataObjectAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be DataObject. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	/// </remarks>
	// Token: 0x0200016E RID: 366
	public class vtkDataObjectAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060045F2 RID: 17906 RVA: 0x00065AE4 File Offset: 0x00063CE4
		static vtkDataObjectAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060045F3 RID: 17907 RVA: 0x00065B0C File Offset: 0x00063D0C
		public vtkDataObjectAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060045F4 RID: 17908
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045F5 RID: 17909 RVA: 0x00065B1C File Offset: 0x00063D1C
		public new static vtkDataObjectAlgorithm New()
		{
			vtkDataObjectAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045F6 RID: 17910 RVA: 0x00065B70 File Offset: 0x00063D70
		public vtkDataObjectAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060045F7 RID: 17911 RVA: 0x00065BB4 File Offset: 0x00063DB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060045F8 RID: 17912
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060045F9 RID: 17913 RVA: 0x00065BC0 File Offset: 0x00063DC0
		public void AddInputData(vtkDataObject arg0)
		{
			vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060045FA RID: 17914
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060045FB RID: 17915 RVA: 0x00065BF0 File Offset: 0x00063DF0
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060045FC RID: 17916
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x060045FD RID: 17917 RVA: 0x00065C20 File Offset: 0x00063E20
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060045FE RID: 17918
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x060045FF RID: 17919 RVA: 0x00065C90 File Offset: 0x00063E90
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004600 RID: 17920
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectAlgorithm_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004601 RID: 17921 RVA: 0x00065D00 File Offset: 0x00063F00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06004602 RID: 17922
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectAlgorithm_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004603 RID: 17923 RVA: 0x00065D20 File Offset: 0x00063F20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06004604 RID: 17924
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_GetOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06004605 RID: 17925 RVA: 0x00065D3C File Offset: 0x00063F3C
		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_GetOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004606 RID: 17926
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_GetOutput_08(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06004607 RID: 17927 RVA: 0x00065DAC File Offset: 0x00063FAC
		public vtkDataObject GetOutput(int arg0)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_GetOutput_08(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06004608 RID: 17928
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectAlgorithm_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004609 RID: 17929 RVA: 0x00065E1C File Offset: 0x0006401C
		public override int IsA(string type)
		{
			return vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600460A RID: 17930
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectAlgorithm_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600460B RID: 17931 RVA: 0x00065E3C File Offset: 0x0006403C
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_IsTypeOf_10(type);
		}

		// Token: 0x0600460C RID: 17932
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600460D RID: 17933 RVA: 0x00065E58 File Offset: 0x00064058
		public new vtkDataObjectAlgorithm NewInstance()
		{
			vtkDataObjectAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600460E RID: 17934
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectAlgorithm_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600460F RID: 17935 RVA: 0x00065EB4 File Offset: 0x000640B4
		public new static vtkDataObjectAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectAlgorithm vtkDataObjectAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectAlgorithm = (vtkDataObjectAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectAlgorithm.Register(null);
				}
			}
			return vtkDataObjectAlgorithm;
		}

		// Token: 0x06004610 RID: 17936
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectAlgorithm_SetInputData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06004611 RID: 17937 RVA: 0x00065F34 File Offset: 0x00064134
		public void SetInputData(vtkDataObject arg0)
		{
			vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_SetInputData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06004612 RID: 17938
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectAlgorithm_SetInputData_15(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06004613 RID: 17939 RVA: 0x00065F64 File Offset: 0x00064164
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_SetInputData_15(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06004614 RID: 17940
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectAlgorithm_SetOutput_16(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06004615 RID: 17941 RVA: 0x00065F94 File Offset: 0x00064194
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkDataObjectAlgorithm.vtkDataObjectAlgorithm_SetOutput_16(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400072B RID: 1835
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400072C RID: 1836
		public new static readonly string MRClassNameKey = "class vtkDataObjectAlgorithm";
	}
}
