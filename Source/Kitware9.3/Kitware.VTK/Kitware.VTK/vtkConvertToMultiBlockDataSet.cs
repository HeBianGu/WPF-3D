using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkConvertToMultiBlockDataSet
	/// </summary>
	/// <remarks>
	///  converts any data type into a vtkMultiBlockDataSet.
	///
	/// vtkConvertToMultiBlockDataSet can convert any input dataset type to a
	/// vtkMultiBlockDataSet. It packs the input dataset into a single
	/// block for non-composite datasets, and for composite datasets
	/// it attempts create a multiblock reflecting the input's hierarchical
	/// organization. If input a vtkMultiBlockDataSet, then this acts as a simple
	/// pass through filters.
	///
	/// </remarks>
	/// <seealso>
	///  vtkPConvertToMultiBlockDataSet
	/// </seealso>
	// Token: 0x0200050D RID: 1293
	public class vtkConvertToMultiBlockDataSet : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E7CE RID: 59342 RVA: 0x00142F03 File Offset: 0x00141103
		static vtkConvertToMultiBlockDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConvertToMultiBlockDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConvertToMultiBlockDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7CF RID: 59343 RVA: 0x00142F2B File Offset: 0x0014112B
		public vtkConvertToMultiBlockDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E7D0 RID: 59344
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToMultiBlockDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7D1 RID: 59345 RVA: 0x00142F3C File Offset: 0x0014113C
		public new static vtkConvertToMultiBlockDataSet New()
		{
			vtkConvertToMultiBlockDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7D2 RID: 59346 RVA: 0x00142F90 File Offset: 0x00141190
		public vtkConvertToMultiBlockDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7D3 RID: 59347 RVA: 0x00142FD4 File Offset: 0x001411D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E7D4 RID: 59348
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7D5 RID: 59349 RVA: 0x00142FE0 File Offset: 0x001411E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E7D6 RID: 59350
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7D7 RID: 59351 RVA: 0x00143000 File Offset: 0x00141200
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E7D8 RID: 59352
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToMultiBlockDataSet_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7D9 RID: 59353 RVA: 0x0014301C File Offset: 0x0014121C
		public override int IsA(string type)
		{
			return vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E7DA RID: 59354
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConvertToMultiBlockDataSet_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7DB RID: 59355 RVA: 0x0014303C File Offset: 0x0014123C
		public new static int IsTypeOf(string type)
		{
			return vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_IsTypeOf_04(type);
		}

		// Token: 0x0600E7DC RID: 59356
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToMultiBlockDataSet_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7DD RID: 59357 RVA: 0x00143058 File Offset: 0x00141258
		public new vtkConvertToMultiBlockDataSet NewInstance()
		{
			vtkConvertToMultiBlockDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConvertToMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E7DE RID: 59358
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConvertToMultiBlockDataSet_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7DF RID: 59359 RVA: 0x001430B4 File Offset: 0x001412B4
		public new static vtkConvertToMultiBlockDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkConvertToMultiBlockDataSet vtkConvertToMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConvertToMultiBlockDataSet.vtkConvertToMultiBlockDataSet_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConvertToMultiBlockDataSet = (vtkConvertToMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConvertToMultiBlockDataSet.Register(null);
				}
			}
			return vtkConvertToMultiBlockDataSet;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001104 RID: 4356
		public new const string MRFullTypeName = "Kitware.VTK.vtkConvertToMultiBlockDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001105 RID: 4357
		public new static readonly string MRClassNameKey = "class vtkConvertToMultiBlockDataSet";
	}
}
