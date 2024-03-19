using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAlgorithmOutput
	/// </summary>
	/// <remarks>
	///    Proxy object to connect input/output ports.
	///
	/// vtkAlgorithmOutput is a proxy object returned by the GetOutputPort
	/// method of vtkAlgorithm.  It may be passed to the
	/// SetInputConnection, AddInputConnection, or RemoveInputConnection
	/// methods of another vtkAlgorithm to establish a connection between
	/// an output and input port.  The connection is not stored in the
	/// proxy object: it is simply a convenience for creating or removing
	/// connections.
	/// </remarks>
	// Token: 0x020009C7 RID: 2503
	public class vtkAlgorithmOutput : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A23E RID: 107070 RVA: 0x002438FB File Offset: 0x00241AFB
		static vtkAlgorithmOutput()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAlgorithmOutput.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlgorithmOutput"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A23F RID: 107071 RVA: 0x00243923 File Offset: 0x00241B23
		public vtkAlgorithmOutput(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A240 RID: 107072
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithmOutput_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A241 RID: 107073 RVA: 0x00243934 File Offset: 0x00241B34
		public new static vtkAlgorithmOutput New()
		{
			vtkAlgorithmOutput result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A242 RID: 107074 RVA: 0x00243988 File Offset: 0x00241B88
		public vtkAlgorithmOutput() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAlgorithmOutput.vtkAlgorithmOutput_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A243 RID: 107075 RVA: 0x002439CC File Offset: 0x00241BCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A244 RID: 107076
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithmOutput_GetIndex_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A245 RID: 107077 RVA: 0x002439D8 File Offset: 0x00241BD8
		public int GetIndex()
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_GetIndex_01(base.GetCppThis());
		}

		// Token: 0x0601A246 RID: 107078
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAlgorithmOutput_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A247 RID: 107079 RVA: 0x002439F8 File Offset: 0x00241BF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A248 RID: 107080
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAlgorithmOutput_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A249 RID: 107081 RVA: 0x00243A18 File Offset: 0x00241C18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A24A RID: 107082
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithmOutput_GetProducer_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A24B RID: 107083 RVA: 0x00243A34 File Offset: 0x00241C34
		public vtkAlgorithm GetProducer()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_GetProducer_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x0601A24C RID: 107084
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithmOutput_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A24D RID: 107085 RVA: 0x00243AA4 File Offset: 0x00241CA4
		public override int IsA(string type)
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A24E RID: 107086
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithmOutput_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A24F RID: 107087 RVA: 0x00243AC4 File Offset: 0x00241CC4
		public new static int IsTypeOf(string type)
		{
			return vtkAlgorithmOutput.vtkAlgorithmOutput_IsTypeOf_06(type);
		}

		// Token: 0x0601A250 RID: 107088
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithmOutput_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A251 RID: 107089 RVA: 0x00243AE0 File Offset: 0x00241CE0
		public new vtkAlgorithmOutput NewInstance()
		{
			vtkAlgorithmOutput result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A252 RID: 107090
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithmOutput_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A253 RID: 107091 RVA: 0x00243B3C File Offset: 0x00241D3C
		public new static vtkAlgorithmOutput SafeDownCast(vtkObjectBase o)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithmOutput.vtkAlgorithmOutput_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0601A254 RID: 107092
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithmOutput_SetIndex_10(HandleRef pThis, int index);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A255 RID: 107093 RVA: 0x00243BBB File Offset: 0x00241DBB
		public void SetIndex(int index)
		{
			vtkAlgorithmOutput.vtkAlgorithmOutput_SetIndex_10(base.GetCppThis(), index);
		}

		// Token: 0x0601A256 RID: 107094
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithmOutput_SetProducer_11(HandleRef pThis, HandleRef producer);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A257 RID: 107095 RVA: 0x00243BCC File Offset: 0x00241DCC
		public void SetProducer(vtkAlgorithm producer)
		{
			vtkAlgorithmOutput.vtkAlgorithmOutput_SetProducer_11(base.GetCppThis(), (producer == null) ? default(HandleRef) : producer.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C5B RID: 7259
		public new const string MRFullTypeName = "Kitware.VTK.vtkAlgorithmOutput";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C5C RID: 7260
		public new static readonly string MRClassNameKey = "class vtkAlgorithmOutput";
	}
}
