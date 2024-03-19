using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBitArrayIterator
	/// </summary>
	/// <remarks>
	///    Iterator for vtkBitArray.
	/// This iterator iterates over a vtkBitArray. It uses the double interface
	/// to get/set bit values.
	/// </remarks>
	// Token: 0x02000B43 RID: 2883
	public class vtkBitArrayIterator : vtkArrayIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E26C RID: 123500 RVA: 0x002AA645 File Offset: 0x002A8845
		static vtkBitArrayIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBitArrayIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBitArrayIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E26D RID: 123501 RVA: 0x002AA66D File Offset: 0x002A886D
		public vtkBitArrayIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E26E RID: 123502
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArrayIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E26F RID: 123503 RVA: 0x002AA67C File Offset: 0x002A887C
		public new static vtkBitArrayIterator New()
		{
			vtkBitArrayIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E270 RID: 123504 RVA: 0x002AA6D0 File Offset: 0x002A88D0
		public vtkBitArrayIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBitArrayIterator.vtkBitArrayIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E271 RID: 123505 RVA: 0x002AA714 File Offset: 0x002A8914
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E272 RID: 123506
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArrayIterator_GetArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the array.
		/// </summary>
		// Token: 0x0601E273 RID: 123507 RVA: 0x002AA720 File Offset: 0x002A8920
		public vtkAbstractArray GetArray()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_GetArray_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601E274 RID: 123508
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArrayIterator_GetDataType_02(HandleRef pThis);

		/// <summary>
		/// Get the data type from the underlying array.
		/// </summary>
		// Token: 0x0601E275 RID: 123509 RVA: 0x002AA790 File Offset: 0x002A8990
		public override int GetDataType()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetDataType_02(base.GetCppThis());
		}

		// Token: 0x0601E276 RID: 123510
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArrayIterator_GetDataTypeSize_03(HandleRef pThis);

		/// <summary>
		/// Get the data type size from the underlying array.
		/// </summary>
		// Token: 0x0601E277 RID: 123511 RVA: 0x002AA7B0 File Offset: 0x002A89B0
		public int GetDataTypeSize()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetDataTypeSize_03(base.GetCppThis());
		}

		// Token: 0x0601E278 RID: 123512
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArrayIterator_GetNumberOfComponents_04(HandleRef pThis);

		/// <summary>
		/// Must be called only after Initialize.
		/// </summary>
		// Token: 0x0601E279 RID: 123513 RVA: 0x002AA7D0 File Offset: 0x002A89D0
		public int GetNumberOfComponents()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfComponents_04(base.GetCppThis());
		}

		// Token: 0x0601E27A RID: 123514
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArrayIterator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E27B RID: 123515 RVA: 0x002AA7F0 File Offset: 0x002A89F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E27C RID: 123516
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArrayIterator_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E27D RID: 123517 RVA: 0x002AA810 File Offset: 0x002A8A10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E27E RID: 123518
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArrayIterator_GetNumberOfTuples_07(HandleRef pThis);

		/// <summary>
		/// Must be called only after Initialize.
		/// </summary>
		// Token: 0x0601E27F RID: 123519 RVA: 0x002AA82C File Offset: 0x002A8A2C
		public long GetNumberOfTuples()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfTuples_07(base.GetCppThis());
		}

		// Token: 0x0601E280 RID: 123520
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArrayIterator_GetNumberOfValues_08(HandleRef pThis);

		/// <summary>
		/// Must be called only after Initialize.
		/// </summary>
		// Token: 0x0601E281 RID: 123521 RVA: 0x002AA84C File Offset: 0x002A8A4C
		public long GetNumberOfValues()
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetNumberOfValues_08(base.GetCppThis());
		}

		// Token: 0x0601E282 RID: 123522
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArrayIterator_GetTuple_09(HandleRef pThis, long id);

		/// <summary>
		/// Must be called only after Initialize.
		/// </summary>
		// Token: 0x0601E283 RID: 123523 RVA: 0x002AA86C File Offset: 0x002A8A6C
		public IntPtr GetTuple(long id)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetTuple_09(base.GetCppThis(), id);
		}

		// Token: 0x0601E284 RID: 123524
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArrayIterator_GetValue_10(HandleRef pThis, long id);

		/// <summary>
		/// Must be called only after Initialize.
		/// </summary>
		// Token: 0x0601E285 RID: 123525 RVA: 0x002AA88C File Offset: 0x002A8A8C
		public int GetValue(long id)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_GetValue_10(base.GetCppThis(), id);
		}

		// Token: 0x0601E286 RID: 123526
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArrayIterator_Initialize_11(HandleRef pThis, HandleRef array);

		/// <summary>
		/// Set the array this iterator will iterate over.
		/// After Initialize() has been called, the iterator is valid
		/// so long as the Array has not been modified
		/// (except using the iterator itself).
		/// If the array is modified, the iterator must be re-initialized.
		/// </summary>
		// Token: 0x0601E287 RID: 123527 RVA: 0x002AA8AC File Offset: 0x002A8AAC
		public override void Initialize(vtkAbstractArray array)
		{
			vtkBitArrayIterator.vtkBitArrayIterator_Initialize_11(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x0601E288 RID: 123528
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArrayIterator_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E289 RID: 123529 RVA: 0x002AA8DC File Offset: 0x002A8ADC
		public override int IsA(string type)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601E28A RID: 123530
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArrayIterator_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E28B RID: 123531 RVA: 0x002AA8FC File Offset: 0x002A8AFC
		public new static int IsTypeOf(string type)
		{
			return vtkBitArrayIterator.vtkBitArrayIterator_IsTypeOf_13(type);
		}

		// Token: 0x0601E28C RID: 123532
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArrayIterator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E28D RID: 123533 RVA: 0x002AA918 File Offset: 0x002A8B18
		public new vtkBitArrayIterator NewInstance()
		{
			vtkBitArrayIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E28E RID: 123534
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArrayIterator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E28F RID: 123535 RVA: 0x002AA974 File Offset: 0x002A8B74
		public new static vtkBitArrayIterator SafeDownCast(vtkObjectBase o)
		{
			vtkBitArrayIterator vtkBitArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArrayIterator.vtkBitArrayIterator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBitArrayIterator = (vtkBitArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBitArrayIterator.Register(null);
				}
			}
			return vtkBitArrayIterator;
		}

		// Token: 0x0601E290 RID: 123536
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArrayIterator_SetValue_17(HandleRef pThis, long id, int value);

		/// <summary>
		/// Sets the value at the index. This does not verify if the index is valid.
		/// The caller must ensure that id is less than the maximum number of values.
		/// </summary>
		// Token: 0x0601E291 RID: 123537 RVA: 0x002AA9F3 File Offset: 0x002A8BF3
		public void SetValue(long id, int value)
		{
			vtkBitArrayIterator.vtkBitArrayIterator_SetValue_17(base.GetCppThis(), id, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FD9 RID: 8153
		public new const string MRFullTypeName = "Kitware.VTK.vtkBitArrayIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FDA RID: 8154
		public new static readonly string MRClassNameKey = "class vtkBitArrayIterator";
	}
}
