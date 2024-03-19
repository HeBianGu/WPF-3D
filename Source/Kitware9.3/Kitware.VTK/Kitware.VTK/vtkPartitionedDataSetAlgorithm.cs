using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPartitionedDataSetAlgorithm
	/// </summary>
	/// <remarks>
	///  Superclass for algorithms that produce vtkPartitionedDataSetAlgorithm
	///
	/// vtkPartitionedDataSetAlgorithm is intended as a superclass for algorithms that
	/// produce a vtkPartitionedDataSet.
	/// </remarks>
	// Token: 0x02000495 RID: 1173
	public class vtkPartitionedDataSetAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D7B7 RID: 55223 RVA: 0x0012BE9B File Offset: 0x0012A09B
		static vtkPartitionedDataSetAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionedDataSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D7B8 RID: 55224 RVA: 0x0012BEC3 File Offset: 0x0012A0C3
		public vtkPartitionedDataSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D7B9 RID: 55225 RVA: 0x0012BED1 File Offset: 0x0012A0D1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D7BA RID: 55226
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7BB RID: 55227 RVA: 0x0012BEDC File Offset: 0x0012A0DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D7BC RID: 55228
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7BD RID: 55229 RVA: 0x0012BEFC File Offset: 0x0012A0FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D7BE RID: 55230
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for the specified output port.
		/// </summary>
		// Token: 0x0600D7BF RID: 55231 RVA: 0x0012BF18 File Offset: 0x0012A118
		public vtkPartitionedDataSet GetOutput()
		{
			vtkPartitionedDataSet vtkPartitionedDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSet = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSet.Register(null);
				}
			}
			return vtkPartitionedDataSet;
		}

		// Token: 0x0600D7C0 RID: 55232
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for the specified output port.
		/// </summary>
		// Token: 0x0600D7C1 RID: 55233 RVA: 0x0012BF88 File Offset: 0x0012A188
		public vtkPartitionedDataSet GetOutput(int arg0)
		{
			vtkPartitionedDataSet vtkPartitionedDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSet = (vtkPartitionedDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSet.Register(null);
				}
			}
			return vtkPartitionedDataSet;
		}

		// Token: 0x0600D7C2 RID: 55234
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7C3 RID: 55235 RVA: 0x0012BFF8 File Offset: 0x0012A1F8
		public override int IsA(string type)
		{
			return vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D7C4 RID: 55236
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7C5 RID: 55237 RVA: 0x0012C018 File Offset: 0x0012A218
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x0600D7C6 RID: 55238
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetAlgorithm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7C7 RID: 55239 RVA: 0x0012C034 File Offset: 0x0012A234
		public new vtkPartitionedDataSetAlgorithm NewInstance()
		{
			vtkPartitionedDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D7C8 RID: 55240
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetAlgorithm_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7C9 RID: 55241 RVA: 0x0012C090 File Offset: 0x0012A290
		public new static vtkPartitionedDataSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionedDataSetAlgorithm vtkPartitionedDataSetAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetAlgorithm.vtkPartitionedDataSetAlgorithm_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetAlgorithm = (vtkPartitionedDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetAlgorithm.Register(null);
				}
			}
			return vtkPartitionedDataSetAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD2 RID: 4050
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD3 RID: 4051
		public new static readonly string MRClassNameKey = "class vtkPartitionedDataSetAlgorithm";
	}
}
