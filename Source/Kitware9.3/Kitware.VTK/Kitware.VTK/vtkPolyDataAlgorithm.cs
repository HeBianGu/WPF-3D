using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only polydata as output
	///
	///
	/// vtkPolyDataAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be PolyData. If that
	/// isn't the case then please override this method in your subclass.
	/// </remarks>
	// Token: 0x020000F3 RID: 243
	public class vtkPolyDataAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600324F RID: 12879 RVA: 0x00049F74 File Offset: 0x00048174
		static vtkPolyDataAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003250 RID: 12880 RVA: 0x00049F9C File Offset: 0x0004819C
		public vtkPolyDataAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003251 RID: 12881
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003252 RID: 12882 RVA: 0x00049FAC File Offset: 0x000481AC
		public new static vtkPolyDataAlgorithm New()
		{
			vtkPolyDataAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003253 RID: 12883 RVA: 0x0004A000 File Offset: 0x00048200
		public vtkPolyDataAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003254 RID: 12884 RVA: 0x0004A044 File Offset: 0x00048244
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003255 RID: 12885
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003256 RID: 12886 RVA: 0x0004A050 File Offset: 0x00048250
		public void AddInputData(vtkDataObject arg0)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003257 RID: 12887
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003258 RID: 12888 RVA: 0x0004A080 File Offset: 0x00048280
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003259 RID: 12889
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600325A RID: 12890 RVA: 0x0004A0B0 File Offset: 0x000482B0
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600325B RID: 12891
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x0600325C RID: 12892 RVA: 0x0004A120 File Offset: 0x00048320
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600325D RID: 12893
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataAlgorithm_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600325E RID: 12894 RVA: 0x0004A190 File Offset: 0x00048390
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600325F RID: 12895
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataAlgorithm_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003260 RID: 12896 RVA: 0x0004A1B0 File Offset: 0x000483B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06003261 RID: 12897
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003262 RID: 12898 RVA: 0x0004A1CC File Offset: 0x000483CC
		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003263 RID: 12899
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetOutput_08(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003264 RID: 12900 RVA: 0x0004A23C File Offset: 0x0004843C
		public vtkPolyData GetOutput(int arg0)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetOutput_08(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003265 RID: 12901
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_GetPolyDataInput_09(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06003266 RID: 12902 RVA: 0x0004A2AC File Offset: 0x000484AC
		public vtkPolyData GetPolyDataInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_GetPolyDataInput_09(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003267 RID: 12903
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003268 RID: 12904 RVA: 0x0004A31C File Offset: 0x0004851C
		public override int IsA(string type)
		{
			return vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06003269 RID: 12905
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600326A RID: 12906 RVA: 0x0004A33C File Offset: 0x0004853C
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x0600326B RID: 12907
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600326C RID: 12908 RVA: 0x0004A358 File Offset: 0x00048558
		public new vtkPolyDataAlgorithm NewInstance()
		{
			vtkPolyDataAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600326D RID: 12909
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600326E RID: 12910 RVA: 0x0004A3B4 File Offset: 0x000485B4
		public new static vtkPolyDataAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x0600326F RID: 12911
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003270 RID: 12912 RVA: 0x0004A434 File Offset: 0x00048634
		public void SetInputData(vtkDataObject arg0)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003271 RID: 12913
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003272 RID: 12914 RVA: 0x0004A464 File Offset: 0x00048664
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SetInputData_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003273 RID: 12915
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003274 RID: 12916 RVA: 0x0004A494 File Offset: 0x00048694
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkPolyDataAlgorithm.vtkPolyDataAlgorithm_SetOutput_17(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005F5 RID: 1525
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005F6 RID: 1526
		public new static readonly string MRClassNameKey = "class vtkPolyDataAlgorithm";
	}
}
