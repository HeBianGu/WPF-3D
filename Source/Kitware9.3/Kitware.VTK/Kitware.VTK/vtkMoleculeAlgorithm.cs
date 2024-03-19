using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that operate on
	/// vtkMolecules
	///
	///
	///
	/// vtkMoleculeAlgorithm is a convenience class to make writing algorithms
	/// easier. There are some assumptions and defaults made by this class you
	/// should be aware of. This class defaults such that your filter will have
	/// one input port and one output port. If that is not the case simply change
	/// it with SetNumberOfInputPorts etc. See this class constructor for the
	/// default. This class also provides a FillInputPortInfo method that by
	/// default says that all inputs will be vtkMolecules. If that isn't the case
	/// then please override this method in your subclass. You should implement
	/// the subclass's algorithm into RequestData( request, inputVec, outputVec).
	/// </remarks>
	// Token: 0x020001CB RID: 459
	public class vtkMoleculeAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600590D RID: 22797 RVA: 0x0008069D File Offset: 0x0007E89D
		static vtkMoleculeAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600590E RID: 22798 RVA: 0x000806C5 File Offset: 0x0007E8C5
		public vtkMoleculeAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600590F RID: 22799
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005910 RID: 22800 RVA: 0x000806D4 File Offset: 0x0007E8D4
		public new static vtkMoleculeAlgorithm New()
		{
			vtkMoleculeAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005911 RID: 22801 RVA: 0x00080728 File Offset: 0x0007E928
		public vtkMoleculeAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005912 RID: 22802 RVA: 0x0008076C File Offset: 0x0007E96C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005913 RID: 22803
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an input of this algorithm.  Note that these methods support
		/// old-style pipeline connections.  When writing new code you should
		/// use the more general vtkAlgorithm::AddInputConnection().  See
		/// SetInputData() for details.
		/// </summary>
		// Token: 0x06005914 RID: 22804 RVA: 0x00080778 File Offset: 0x0007E978
		public void AddInputData(vtkDataObject arg0)
		{
			vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005915 RID: 22805
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Add an input of this algorithm.  Note that these methods support
		/// old-style pipeline connections.  When writing new code you should
		/// use the more general vtkAlgorithm::AddInputConnection().  See
		/// SetInputData() for details.
		/// </summary>
		// Token: 0x06005916 RID: 22806 RVA: 0x000807A8 File Offset: 0x0007E9A8
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005917 RID: 22807
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06005918 RID: 22808 RVA: 0x000807D8 File Offset: 0x0007E9D8
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005919 RID: 22809
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600591A RID: 22810 RVA: 0x00080848 File Offset: 0x0007EA48
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600591B RID: 22811
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_GetMoleculeInput_05(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600591C RID: 22812 RVA: 0x000808B8 File Offset: 0x0007EAB8
		public vtkMolecule GetMoleculeInput(int port)
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetMoleculeInput_05(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600591D RID: 22813
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600591E RID: 22814 RVA: 0x00080928 File Offset: 0x0007EB28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600591F RID: 22815
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005920 RID: 22816 RVA: 0x00080948 File Offset: 0x0007EB48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06005921 RID: 22817
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005922 RID: 22818 RVA: 0x00080964 File Offset: 0x0007EB64
		public vtkMolecule GetOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005923 RID: 22819
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_GetOutput_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005924 RID: 22820 RVA: 0x000809D4 File Offset: 0x0007EBD4
		public vtkMolecule GetOutput(int arg0)
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_GetOutput_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005925 RID: 22821
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005926 RID: 22822 RVA: 0x00080A44 File Offset: 0x0007EC44
		public override int IsA(string type)
		{
			return vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06005927 RID: 22823
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005928 RID: 22824 RVA: 0x00080A64 File Offset: 0x0007EC64
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x06005929 RID: 22825
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600592A RID: 22826 RVA: 0x00080A80 File Offset: 0x0007EC80
		public new vtkMoleculeAlgorithm NewInstance()
		{
			vtkMoleculeAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600592B RID: 22827
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600592C RID: 22828 RVA: 0x00080ADC File Offset: 0x0007ECDC
		public new static vtkMoleculeAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeAlgorithm vtkMoleculeAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeAlgorithm = (vtkMoleculeAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeAlgorithm.Register(null);
				}
			}
			return vtkMoleculeAlgorithm;
		}

		// Token: 0x0600592D RID: 22829
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set an input of this algorithm. You should not override these
		/// methods because they are not the only way to connect a pipeline.
		/// Note that these methods support old-style pipeline connections.
		/// When writing new code you should use the more general
		/// vtkAlgorithm::SetInputConnection().  These methods transform the
		/// input index to the input port index, not an index of a connection
		/// within a single port.
		/// </summary>
		// Token: 0x0600592E RID: 22830 RVA: 0x00080B5C File Offset: 0x0007ED5C
		public void SetInputData(vtkDataObject arg0)
		{
			vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600592F RID: 22831
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Set an input of this algorithm. You should not override these
		/// methods because they are not the only way to connect a pipeline.
		/// Note that these methods support old-style pipeline connections.
		/// When writing new code you should use the more general
		/// vtkAlgorithm::SetInputConnection().  These methods transform the
		/// input index to the input port index, not an index of a connection
		/// within a single port.
		/// </summary>
		// Token: 0x06005930 RID: 22832 RVA: 0x00080B8C File Offset: 0x0007ED8C
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_SetInputData_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005931 RID: 22833
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005932 RID: 22834 RVA: 0x00080BBC File Offset: 0x0007EDBC
		public virtual void SetOutput(vtkMolecule d)
		{
			vtkMoleculeAlgorithm.vtkMoleculeAlgorithm_SetOutput_17(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400085D RID: 2141
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400085E RID: 2142
		public new static readonly string MRClassNameKey = "class vtkMoleculeAlgorithm";
	}
}
