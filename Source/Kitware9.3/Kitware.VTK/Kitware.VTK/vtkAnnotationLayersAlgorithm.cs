using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnnotationLayersAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only vtkAnnotationLayers as output
	///
	///
	/// vtkAnnotationLayersAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be vtkAnnotationLayers. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	/// </remarks>
	// Token: 0x0200086E RID: 2158
	public class vtkAnnotationLayersAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016698 RID: 91800 RVA: 0x001F80DB File Offset: 0x001F62DB
		static vtkAnnotationLayersAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotationLayersAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLayersAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016699 RID: 91801 RVA: 0x001F8103 File Offset: 0x001F6303
		public vtkAnnotationLayersAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601669A RID: 91802
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayersAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601669B RID: 91803 RVA: 0x001F8114 File Offset: 0x001F6314
		public new static vtkAnnotationLayersAlgorithm New()
		{
			vtkAnnotationLayersAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLayersAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601669C RID: 91804 RVA: 0x001F8168 File Offset: 0x001F6368
		public vtkAnnotationLayersAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601669D RID: 91805 RVA: 0x001F81AC File Offset: 0x001F63AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601669E RID: 91806
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotationLayersAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601669F RID: 91807 RVA: 0x001F81B8 File Offset: 0x001F63B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060166A0 RID: 91808
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnnotationLayersAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166A1 RID: 91809 RVA: 0x001F81D8 File Offset: 0x001F63D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060166A2 RID: 91810
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayersAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060166A3 RID: 91811 RVA: 0x001F81F4 File Offset: 0x001F63F4
		public vtkAnnotationLayers GetOutput()
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		// Token: 0x060166A4 RID: 91812
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayersAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060166A5 RID: 91813 RVA: 0x001F8264 File Offset: 0x001F6464
		public vtkAnnotationLayers GetOutput(int index)
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_GetOutput_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		// Token: 0x060166A6 RID: 91814
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLayersAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166A7 RID: 91815 RVA: 0x001F82D4 File Offset: 0x001F64D4
		public override int IsA(string type)
		{
			return vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060166A8 RID: 91816
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnnotationLayersAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166A9 RID: 91817 RVA: 0x001F82F4 File Offset: 0x001F64F4
		public new static int IsTypeOf(string type)
		{
			return vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x060166AA RID: 91818
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayersAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166AB RID: 91819 RVA: 0x001F8310 File Offset: 0x001F6510
		public new vtkAnnotationLayersAlgorithm NewInstance()
		{
			vtkAnnotationLayersAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLayersAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060166AC RID: 91820
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnnotationLayersAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166AD RID: 91821 RVA: 0x001F836C File Offset: 0x001F656C
		public new static vtkAnnotationLayersAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotationLayersAlgorithm vtkAnnotationLayersAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayersAlgorithm = (vtkAnnotationLayersAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayersAlgorithm.Register(null);
				}
			}
			return vtkAnnotationLayersAlgorithm;
		}

		// Token: 0x060166AE RID: 91822
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayersAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060166AF RID: 91823 RVA: 0x001F83EC File Offset: 0x001F65EC
		public void SetInputData(vtkDataObject obj)
		{
			vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_SetInputData_10(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x060166B0 RID: 91824
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnnotationLayersAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060166B1 RID: 91825 RVA: 0x001F841C File Offset: 0x001F661C
		public void SetInputData(int index, vtkDataObject obj)
		{
			vtkAnnotationLayersAlgorithm.vtkAnnotationLayersAlgorithm_SetInputData_11(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001932 RID: 6450
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLayersAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001933 RID: 6451
		public new static readonly string MRClassNameKey = "class vtkAnnotationLayersAlgorithm";
	}
}
