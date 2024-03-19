using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkConvertToPartitionedDataSetCollection
	/// </summary>
	/// <remarks>
	///  convert any dataset to vtkPartitionedDataSetCollection.
	///
	/// vtkConvertToPartitionedDataSetCollection converts any dataset to a
	/// vtkPartitionedDataSetCollection. If the input is a multiblock dataset or an
	/// AMR dataset, it creates a vtkDataAssembly for the output
	/// vtkPartitionedDataSetCollection that reflects the input's hierarchical
	/// organization.
	///
	/// </remarks>
	/// <seealso>
	///  vtkDataAssemblyUtilities
	/// </seealso>
	// Token: 0x02000953 RID: 2387
	public class vtkConvertToPartitionedDataSetCollection : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018C59 RID: 101465 RVA: 0x00229317 File Offset: 0x00227517
		static vtkConvertToPartitionedDataSetCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertToPartitionedDataSetCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertToPartitionedDataSetCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018C5A RID: 101466 RVA: 0x0022933F File Offset: 0x0022753F
		public vtkConvertToPartitionedDataSetCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018C5B RID: 101467
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPartitionedDataSetCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C5C RID: 101468 RVA: 0x00229350 File Offset: 0x00227550
		public new static vtkConvertToPartitionedDataSetCollection New()
		{
			vtkConvertToPartitionedDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C5D RID: 101469 RVA: 0x002293A4 File Offset: 0x002275A4
		public vtkConvertToPartitionedDataSetCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018C5E RID: 101470 RVA: 0x002293E8 File Offset: 0x002275E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018C5F RID: 101471
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C60 RID: 101472 RVA: 0x002293F4 File Offset: 0x002275F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018C61 RID: 101473
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C62 RID: 101474 RVA: 0x00229414 File Offset: 0x00227614
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018C63 RID: 101475
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPartitionedDataSetCollection_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C64 RID: 101476 RVA: 0x00229430 File Offset: 0x00227630
		public override int IsA(string type)
		{
			return vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06018C65 RID: 101477
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToPartitionedDataSetCollection_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C66 RID: 101478 RVA: 0x00229450 File Offset: 0x00227650
		public new static int IsTypeOf(string type)
		{
			return vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_IsTypeOf_04(type);
		}

		// Token: 0x06018C67 RID: 101479
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPartitionedDataSetCollection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C68 RID: 101480 RVA: 0x0022946C File Offset: 0x0022766C
		public new vtkConvertToPartitionedDataSetCollection NewInstance()
		{
			vtkConvertToPartitionedDataSetCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018C69 RID: 101481
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToPartitionedDataSetCollection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C6A RID: 101482 RVA: 0x002294C8 File Offset: 0x002276C8
		public new static vtkConvertToPartitionedDataSetCollection SafeDownCast(vtkObjectBase o)
		{
			vtkConvertToPartitionedDataSetCollection vtkConvertToPartitionedDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToPartitionedDataSetCollection.vtkConvertToPartitionedDataSetCollection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertToPartitionedDataSetCollection = (vtkConvertToPartitionedDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertToPartitionedDataSetCollection.Register(null);
				}
			}
			return vtkConvertToPartitionedDataSetCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B5F RID: 7007
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertToPartitionedDataSetCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B60 RID: 7008
		public new static readonly string MRClassNameKey = "class vtkConvertToPartitionedDataSetCollection";
	}
}
