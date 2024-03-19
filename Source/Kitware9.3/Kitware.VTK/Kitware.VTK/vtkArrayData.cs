using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayData
	/// </summary>
	/// <remarks>
	///    Pipeline data object that contains multiple vtkArray objects.
	///
	///
	/// Because vtkArray cannot be stored as attributes of data objects (yet), a "carrier"
	/// object is needed to pass vtkArray through the pipeline.  vtkArrayData acts as a
	/// container of zero-to-many vtkArray instances, which can be retrieved via a zero-based
	/// index.  Note that a collection of arrays stored in vtkArrayData may-or-may-not have related
	/// types, dimensions, or extents.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArrayDataAlgorithm, vtkArray
	///
	/// @par Thanks:
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x020009F9 RID: 2553
	public class vtkArrayData : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A7C4 RID: 108484 RVA: 0x0024CB97 File Offset: 0x0024AD97
		static vtkArrayData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A7C5 RID: 108485 RVA: 0x0024CBBF File Offset: 0x0024ADBF
		public vtkArrayData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A7C6 RID: 108486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7C7 RID: 108487 RVA: 0x0024CBD0 File Offset: 0x0024ADD0
		public new static vtkArrayData New()
		{
			vtkArrayData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7C8 RID: 108488 RVA: 0x0024CC24 File Offset: 0x0024AE24
		public vtkArrayData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayData.vtkArrayData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A7C9 RID: 108489 RVA: 0x0024CC68 File Offset: 0x0024AE68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A7CA RID: 108490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayData_AddArray_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Adds a vtkArray to the collection
		/// </summary>
		// Token: 0x0601A7CB RID: 108491 RVA: 0x0024CC74 File Offset: 0x0024AE74
		public void AddArray(vtkArray arg0)
		{
			vtkArrayData.vtkArrayData_AddArray_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A7CC RID: 108492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayData_ClearArrays_02(HandleRef pThis);

		/// <summary>
		/// Clears the contents of the collection
		/// </summary>
		// Token: 0x0601A7CD RID: 108493 RVA: 0x0024CCA3 File Offset: 0x0024AEA3
		public void ClearArrays()
		{
			vtkArrayData.vtkArrayData_ClearArrays_02(base.GetCppThis());
		}

		// Token: 0x0601A7CE RID: 108494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayData_DeepCopy_03(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Return class name of data type (VTK_ARRAY_DATA).
		/// </summary>
		// Token: 0x0601A7CF RID: 108495 RVA: 0x0024CCB4 File Offset: 0x0024AEB4
		public override void DeepCopy(vtkDataObject other)
		{
			vtkArrayData.vtkArrayData_DeepCopy_03(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601A7D0 RID: 108496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_GetArray_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the n-th vtkArray in the collection
		/// </summary>
		// Token: 0x0601A7D1 RID: 108497 RVA: 0x0024CCE4 File Offset: 0x0024AEE4
		public vtkArray GetArray(long index)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetArray_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		// Token: 0x0601A7D2 RID: 108498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_GetArrayByName_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the array having called name from the collection
		/// </summary>
		// Token: 0x0601A7D3 RID: 108499 RVA: 0x0024CD54 File Offset: 0x0024AF54
		public vtkArray GetArrayByName(string name)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetArrayByName_05(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		// Token: 0x0601A7D4 RID: 108500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7D5 RID: 108501 RVA: 0x0024CDC4 File Offset: 0x0024AFC4
		public new static vtkArrayData GetData(vtkInformation info)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		// Token: 0x0601A7D6 RID: 108502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7D7 RID: 108503 RVA: 0x0024CE44 File Offset: 0x0024B044
		public new static vtkArrayData GetData(vtkInformationVector v, int i)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		// Token: 0x0601A7D8 RID: 108504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayData_GetDataObjectType_08(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (VTK_ARRAY_DATA).
		/// </summary>
		// Token: 0x0601A7D9 RID: 108505 RVA: 0x0024CEC4 File Offset: 0x0024B0C4
		public override int GetDataObjectType()
		{
			return vtkArrayData.vtkArrayData_GetDataObjectType_08(base.GetCppThis());
		}

		// Token: 0x0601A7DA RID: 108506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayData_GetNumberOfArrays_09(HandleRef pThis);

		/// <summary>
		/// Returns the number of vtkArray instances in the collection
		/// </summary>
		// Token: 0x0601A7DB RID: 108507 RVA: 0x0024CEE4 File Offset: 0x0024B0E4
		public long GetNumberOfArrays()
		{
			return vtkArrayData.vtkArrayData_GetNumberOfArrays_09(base.GetCppThis());
		}

		// Token: 0x0601A7DC RID: 108508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayData_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7DD RID: 108509 RVA: 0x0024CF04 File Offset: 0x0024B104
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayData.vtkArrayData_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601A7DE RID: 108510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayData_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7DF RID: 108511 RVA: 0x0024CF24 File Offset: 0x0024B124
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayData.vtkArrayData_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601A7E0 RID: 108512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayData_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7E1 RID: 108513 RVA: 0x0024CF40 File Offset: 0x0024B140
		public override int IsA(string type)
		{
			return vtkArrayData.vtkArrayData_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601A7E2 RID: 108514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayData_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7E3 RID: 108515 RVA: 0x0024CF60 File Offset: 0x0024B160
		public new static int IsTypeOf(string type)
		{
			return vtkArrayData.vtkArrayData_IsTypeOf_13(type);
		}

		// Token: 0x0601A7E4 RID: 108516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7E5 RID: 108517 RVA: 0x0024CF7C File Offset: 0x0024B17C
		public new vtkArrayData NewInstance()
		{
			vtkArrayData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A7E6 RID: 108518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayData_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A7E7 RID: 108519 RVA: 0x0024CFD8 File Offset: 0x0024B1D8
		public new static vtkArrayData SafeDownCast(vtkObjectBase o)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayData.vtkArrayData_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		// Token: 0x0601A7E8 RID: 108520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayData_ShallowCopy_17(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Return class name of data type (VTK_ARRAY_DATA).
		/// </summary>
		// Token: 0x0601A7E9 RID: 108521 RVA: 0x0024D058 File Offset: 0x0024B258
		public override void ShallowCopy(vtkDataObject other)
		{
			vtkArrayData.vtkArrayData_ShallowCopy_17(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CCA RID: 7370
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CCB RID: 7371
		public new static readonly string MRClassNameKey = "class vtkArrayData";
	}
}
