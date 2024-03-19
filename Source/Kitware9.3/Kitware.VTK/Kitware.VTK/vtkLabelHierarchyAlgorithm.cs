using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelHierarchyAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only label hierarchies as output
	///
	///
	/// vtkLabelHierarchyAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be DataObjects. If that
	/// isn't the case then please override this method in your subclass. This
	/// class breaks out the downstream requests into separate functions such as
	/// RequestData and RequestInformation.  You should
	/// implement RequestData( request, inputVec, outputVec) in subclasses.
	/// </remarks>
	// Token: 0x020000ED RID: 237
	public class vtkLabelHierarchyAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003150 RID: 12624 RVA: 0x000489EB File Offset: 0x00046BEB
		static vtkLabelHierarchyAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchyAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchyAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003151 RID: 12625 RVA: 0x00048A13 File Offset: 0x00046C13
		public vtkLabelHierarchyAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003152 RID: 12626
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003153 RID: 12627 RVA: 0x00048A24 File Offset: 0x00046C24
		public new static vtkLabelHierarchyAlgorithm New()
		{
			vtkLabelHierarchyAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003154 RID: 12628 RVA: 0x00048A78 File Offset: 0x00046C78
		public vtkLabelHierarchyAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003155 RID: 12629 RVA: 0x00048ABC File Offset: 0x00046CBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003156 RID: 12630
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003157 RID: 12631 RVA: 0x00048AC8 File Offset: 0x00046CC8
		public void AddInputData(vtkDataObject arg0)
		{
			vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003158 RID: 12632
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003159 RID: 12633 RVA: 0x00048AF8 File Offset: 0x00046CF8
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600315A RID: 12634
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600315B RID: 12635 RVA: 0x00048B28 File Offset: 0x00046D28
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600315C RID: 12636
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600315D RID: 12637 RVA: 0x00048B98 File Offset: 0x00046D98
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600315E RID: 12638
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_GetLabelHierarchyInput_05(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600315F RID: 12639 RVA: 0x00048C08 File Offset: 0x00046E08
		public vtkLabelHierarchy GetLabelHierarchyInput(int port)
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetLabelHierarchyInput_05(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		// Token: 0x06003160 RID: 12640
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003161 RID: 12641 RVA: 0x00048C78 File Offset: 0x00046E78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06003162 RID: 12642
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchyAlgorithm_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003163 RID: 12643 RVA: 0x00048C98 File Offset: 0x00046E98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06003164 RID: 12644
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003165 RID: 12645 RVA: 0x00048CB4 File Offset: 0x00046EB4
		public vtkLabelHierarchy GetOutput()
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		// Token: 0x06003166 RID: 12646
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_GetOutput_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003167 RID: 12647 RVA: 0x00048D24 File Offset: 0x00046F24
		public vtkLabelHierarchy GetOutput(int arg0)
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_GetOutput_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		// Token: 0x06003168 RID: 12648
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003169 RID: 12649 RVA: 0x00048D94 File Offset: 0x00046F94
		public override int IsA(string type)
		{
			return vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600316A RID: 12650
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchyAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600316B RID: 12651 RVA: 0x00048DB4 File Offset: 0x00046FB4
		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x0600316C RID: 12652
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600316D RID: 12653 RVA: 0x00048DD0 File Offset: 0x00046FD0
		public new vtkLabelHierarchyAlgorithm NewInstance()
		{
			vtkLabelHierarchyAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchyAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600316E RID: 12654
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchyAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600316F RID: 12655 RVA: 0x00048E2C File Offset: 0x0004702C
		public new static vtkLabelHierarchyAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchyAlgorithm vtkLabelHierarchyAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyAlgorithm = (vtkLabelHierarchyAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyAlgorithm.Register(null);
				}
			}
			return vtkLabelHierarchyAlgorithm;
		}

		// Token: 0x06003170 RID: 12656
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003171 RID: 12657 RVA: 0x00048EAC File Offset: 0x000470AC
		public void SetInputData(vtkDataObject arg0)
		{
			vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003172 RID: 12658
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003173 RID: 12659 RVA: 0x00048EDC File Offset: 0x000470DC
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_SetInputData_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003174 RID: 12660
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchyAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003175 RID: 12661 RVA: 0x00048F0C File Offset: 0x0004710C
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkLabelHierarchyAlgorithm.vtkLabelHierarchyAlgorithm_SetOutput_17(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005E4 RID: 1508
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchyAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005E5 RID: 1509
		public new static readonly string MRClassNameKey = "class vtkLabelHierarchyAlgorithm";
	}
}
