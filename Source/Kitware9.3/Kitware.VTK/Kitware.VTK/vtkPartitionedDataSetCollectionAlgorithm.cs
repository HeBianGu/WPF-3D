using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPartitionedDataSetCollectionAlgorithm
	/// </summary>
	/// <remarks>
	///  Superclass for algorithms that produce vtkPartitionedDataSetCollectionAlgorithm
	///
	/// vtkPartitionedDataSetCollectionAlgorithm is intended as a superclass for algorithms that
	/// produce a vtkPartitionedDataSetCollection.
	/// </remarks>
	// Token: 0x0200018F RID: 399
	public class vtkPartitionedDataSetCollectionAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004E13 RID: 19987 RVA: 0x000716DD File Offset: 0x0006F8DD
		static vtkPartitionedDataSetCollectionAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionedDataSetCollectionAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetCollectionAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004E14 RID: 19988 RVA: 0x00071705 File Offset: 0x0006F905
		public vtkPartitionedDataSetCollectionAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004E15 RID: 19989 RVA: 0x00071713 File Offset: 0x0006F913
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004E16 RID: 19990
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E17 RID: 19991 RVA: 0x00071720 File Offset: 0x0006F920
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06004E18 RID: 19992
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E19 RID: 19993 RVA: 0x00071740 File Offset: 0x0006F940
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06004E1A RID: 19994
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for the specified output port.
		/// </summary>
		// Token: 0x06004E1B RID: 19995 RVA: 0x0007175C File Offset: 0x0006F95C
		public vtkPartitionedDataSetCollection GetOutput()
		{
			vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollection = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkPartitionedDataSetCollection;
		}

		// Token: 0x06004E1C RID: 19996
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for the specified output port.
		/// </summary>
		// Token: 0x06004E1D RID: 19997 RVA: 0x000717CC File Offset: 0x0006F9CC
		public vtkPartitionedDataSetCollection GetOutput(int arg0)
		{
			vtkPartitionedDataSetCollection vtkPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollection = (vtkPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkPartitionedDataSetCollection;
		}

		// Token: 0x06004E1E RID: 19998
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E1F RID: 19999 RVA: 0x0007183C File Offset: 0x0006FA3C
		public override int IsA(string type)
		{
			return vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06004E20 RID: 20000
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E21 RID: 20001 RVA: 0x0007185C File Offset: 0x0006FA5C
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06004E22 RID: 20002
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E23 RID: 20003 RVA: 0x00071878 File Offset: 0x0006FA78
		public new vtkPartitionedDataSetCollectionAlgorithm NewInstance()
		{
			vtkPartitionedDataSetCollectionAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetCollectionAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004E24 RID: 20004
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionAlgorithm_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E25 RID: 20005 RVA: 0x000718D4 File Offset: 0x0006FAD4
		public new static vtkPartitionedDataSetCollectionAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionedDataSetCollectionAlgorithm vtkPartitionedDataSetCollectionAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionAlgorithm.vtkPartitionedDataSetCollectionAlgorithm_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollectionAlgorithm = (vtkPartitionedDataSetCollectionAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollectionAlgorithm.Register(null);
				}
			}
			return vtkPartitionedDataSetCollectionAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400077F RID: 1919
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetCollectionAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000780 RID: 1920
		public new static readonly string MRClassNameKey = "class vtkPartitionedDataSetCollectionAlgorithm";
	}
}
