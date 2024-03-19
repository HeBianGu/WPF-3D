using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoidArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of void* pointers
	///
	/// vtkVoidArray is an array of pointers to void. It provides methods
	/// for insertion and retrieval of these pointers values, and will
	/// automatically resize itself to hold new data.
	/// </remarks>
	// Token: 0x02000B89 RID: 2953
	public class vtkVoidArray : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ECE5 RID: 126181 RVA: 0x002BB103 File Offset: 0x002B9303
		static vtkVoidArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoidArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoidArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ECE6 RID: 126182 RVA: 0x002BB12B File Offset: 0x002B932B
		public vtkVoidArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ECE7 RID: 126183
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoidArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ECE8 RID: 126184 RVA: 0x002BB13C File Offset: 0x002B933C
		public new static vtkVoidArray New()
		{
			vtkVoidArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ECE9 RID: 126185 RVA: 0x002BB190 File Offset: 0x002B9390
		public vtkVoidArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoidArray.vtkVoidArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ECEA RID: 126186 RVA: 0x002BB1D4 File Offset: 0x002B93D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ECEB RID: 126187
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoidArray_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate memory for this array. Delete old storage only if necessary.
		/// Note that the parameter ext is no longer used.
		/// </summary>
		// Token: 0x0601ECEC RID: 126188 RVA: 0x002BB1E0 File Offset: 0x002B93E0
		public int Allocate(long sz, long ext)
		{
			return vtkVoidArray.vtkVoidArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601ECED RID: 126189
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_DeepCopy_02(HandleRef pThis, HandleRef va);

		/// <summary>
		/// Deep copy of another void array.
		/// </summary>
		// Token: 0x0601ECEE RID: 126190 RVA: 0x002BB204 File Offset: 0x002B9404
		public void DeepCopy(vtkVoidArray va)
		{
			vtkVoidArray.vtkVoidArray_DeepCopy_02(base.GetCppThis(), (va == null) ? default(HandleRef) : va.GetCppThis());
		}

		// Token: 0x0601ECEF RID: 126191
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoidArray_ExtendedNew_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ECF0 RID: 126192 RVA: 0x002BB234 File Offset: 0x002B9434
		public static vtkVoidArray ExtendedNew()
		{
			vtkVoidArray vtkVoidArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_ExtendedNew_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoidArray = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoidArray.Register(null);
				}
			}
			return vtkVoidArray;
		}

		// Token: 0x0601ECF1 RID: 126193
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoidArray_GetDataType_04(HandleRef pThis);

		/// <summary>
		/// Return the type of data.
		/// </summary>
		// Token: 0x0601ECF2 RID: 126194 RVA: 0x002BB2A0 File Offset: 0x002B94A0
		public int GetDataType()
		{
			return vtkVoidArray.vtkVoidArray_GetDataType_04(base.GetCppThis());
		}

		// Token: 0x0601ECF3 RID: 126195
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoidArray_GetDataTypeSize_05(HandleRef pThis);

		/// <summary>
		/// Return the size of the data contained in the array.
		/// </summary>
		// Token: 0x0601ECF4 RID: 126196 RVA: 0x002BB2C0 File Offset: 0x002B94C0
		public int GetDataTypeSize()
		{
			return vtkVoidArray.vtkVoidArray_GetDataTypeSize_05(base.GetCppThis());
		}

		// Token: 0x0601ECF5 RID: 126197
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoidArray_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ECF6 RID: 126198 RVA: 0x002BB2E0 File Offset: 0x002B94E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoidArray.vtkVoidArray_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601ECF7 RID: 126199
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoidArray_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ECF8 RID: 126200 RVA: 0x002BB300 File Offset: 0x002B9500
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoidArray.vtkVoidArray_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601ECF9 RID: 126201
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoidArray_GetNumberOfPointers_08(HandleRef pThis);

		/// <summary>
		/// Get the number of void* pointers held in the array.
		/// </summary>
		// Token: 0x0601ECFA RID: 126202 RVA: 0x002BB31C File Offset: 0x002B951C
		public long GetNumberOfPointers()
		{
			return vtkVoidArray.vtkVoidArray_GetNumberOfPointers_08(base.GetCppThis());
		}

		// Token: 0x0601ECFB RID: 126203
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoidArray_GetVoidPointer_09(HandleRef pThis, long id);

		/// <summary>
		/// Get the void* pointer at the ith location.
		/// </summary>
		// Token: 0x0601ECFC RID: 126204 RVA: 0x002BB33C File Offset: 0x002B953C
		public IntPtr GetVoidPointer(long id)
		{
			return vtkVoidArray.vtkVoidArray_GetVoidPointer_09(base.GetCppThis(), id);
		}

		// Token: 0x0601ECFD RID: 126205
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_Initialize_10(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601ECFE RID: 126206 RVA: 0x002BB35C File Offset: 0x002B955C
		public void Initialize()
		{
			vtkVoidArray.vtkVoidArray_Initialize_10(base.GetCppThis());
		}

		// Token: 0x0601ECFF RID: 126207
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoidArray_InsertNextVoidPointer_11(HandleRef pThis, IntPtr tuple);

		/// <summary>
		/// Insert (memory allocation performed) the void* pointer at the
		/// end of the array.
		/// </summary>
		// Token: 0x0601ED00 RID: 126208 RVA: 0x002BB36C File Offset: 0x002B956C
		public long InsertNextVoidPointer(IntPtr tuple)
		{
			return vtkVoidArray.vtkVoidArray_InsertNextVoidPointer_11(base.GetCppThis(), tuple);
		}

		// Token: 0x0601ED01 RID: 126209
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_InsertVoidPointer_12(HandleRef pThis, long i, IntPtr ptr);

		/// <summary>
		/// Insert (memory allocation performed) the void* into the ith location
		/// in the array.
		/// </summary>
		// Token: 0x0601ED02 RID: 126210 RVA: 0x002BB38C File Offset: 0x002B958C
		public void InsertVoidPointer(long i, IntPtr ptr)
		{
			vtkVoidArray.vtkVoidArray_InsertVoidPointer_12(base.GetCppThis(), i, ptr);
		}

		// Token: 0x0601ED03 RID: 126211
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoidArray_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ED04 RID: 126212 RVA: 0x002BB3A0 File Offset: 0x002B95A0
		public override int IsA(string type)
		{
			return vtkVoidArray.vtkVoidArray_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601ED05 RID: 126213
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoidArray_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ED06 RID: 126214 RVA: 0x002BB3C0 File Offset: 0x002B95C0
		public new static int IsTypeOf(string type)
		{
			return vtkVoidArray.vtkVoidArray_IsTypeOf_14(type);
		}

		// Token: 0x0601ED07 RID: 126215
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoidArray_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ED08 RID: 126216 RVA: 0x002BB3DC File Offset: 0x002B95DC
		public new vtkVoidArray NewInstance()
		{
			vtkVoidArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ED09 RID: 126217
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_Reset_17(HandleRef pThis);

		/// <summary>
		/// Reuse already allocated data; make the container look like it is
		/// empty.
		/// </summary>
		// Token: 0x0601ED0A RID: 126218 RVA: 0x002BB436 File Offset: 0x002B9636
		public void Reset()
		{
			vtkVoidArray.vtkVoidArray_Reset_17(base.GetCppThis());
		}

		// Token: 0x0601ED0B RID: 126219
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoidArray_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Initialize with empty array.
		/// </summary>
		// Token: 0x0601ED0C RID: 126220 RVA: 0x002BB448 File Offset: 0x002B9648
		public new static vtkVoidArray SafeDownCast(vtkObjectBase o)
		{
			vtkVoidArray vtkVoidArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoidArray.vtkVoidArray_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoidArray = (vtkVoidArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoidArray.Register(null);
				}
			}
			return vtkVoidArray;
		}

		// Token: 0x0601ED0D RID: 126221
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_SetNumberOfPointers_19(HandleRef pThis, long number);

		/// <summary>
		/// Set the number of void* pointers held in the array.
		/// </summary>
		// Token: 0x0601ED0E RID: 126222 RVA: 0x002BB4C7 File Offset: 0x002B96C7
		public void SetNumberOfPointers(long number)
		{
			vtkVoidArray.vtkVoidArray_SetNumberOfPointers_19(base.GetCppThis(), number);
		}

		// Token: 0x0601ED0F RID: 126223
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_SetVoidPointer_20(HandleRef pThis, long id, IntPtr ptr);

		/// <summary>
		/// Set the void* pointer value at the ith location in the array.
		/// </summary>
		// Token: 0x0601ED10 RID: 126224 RVA: 0x002BB4D7 File Offset: 0x002B96D7
		public void SetVoidPointer(long id, IntPtr ptr)
		{
			vtkVoidArray.vtkVoidArray_SetVoidPointer_20(base.GetCppThis(), id, ptr);
		}

		// Token: 0x0601ED11 RID: 126225
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoidArray_Squeeze_21(HandleRef pThis);

		/// <summary>
		/// Resize the array to just fit the inserted memory. Reclaims extra memory.
		/// </summary>
		// Token: 0x0601ED12 RID: 126226 RVA: 0x002BB4E8 File Offset: 0x002B96E8
		public void Squeeze()
		{
			vtkVoidArray.vtkVoidArray_Squeeze_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002102 RID: 8450
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoidArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002103 RID: 8451
		public new static readonly string MRClassNameKey = "class vtkVoidArray";
	}
}
