using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIdList
	/// </summary>
	/// <remarks>
	///    list of point or cell ids
	///
	/// vtkIdList is used to represent and pass data id's between
	/// objects. vtkIdList may represent any type of integer id, but
	/// usually represents point and cell ids.
	/// </remarks>
	// Token: 0x02000B55 RID: 2901
	public class vtkIdList : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E49E RID: 124062 RVA: 0x002AD8E9 File Offset: 0x002ABAE9
		static vtkIdList()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdList.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdList"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E49F RID: 124063 RVA: 0x002AD911 File Offset: 0x002ABB11
		public vtkIdList(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E4A0 RID: 124064
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4A1 RID: 124065 RVA: 0x002AD920 File Offset: 0x002ABB20
		public new static vtkIdList New()
		{
			vtkIdList result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdList.vtkIdList_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4A2 RID: 124066 RVA: 0x002AD974 File Offset: 0x002ABB74
		public vtkIdList() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIdList.vtkIdList_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E4A3 RID: 124067 RVA: 0x002AD9B8 File Offset: 0x002ABBB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E4A4 RID: 124068
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdList_Allocate_01(HandleRef pThis, long sz, int strategy);

		/// <summary>
		/// Allocate a capacity for sz ids in the list and
		/// set the number of stored ids in the list to 0.
		/// strategy is not used.
		/// </summary>
		// Token: 0x0601E4A5 RID: 124069 RVA: 0x002AD9C4 File Offset: 0x002ABBC4
		public int Allocate(long sz, int strategy)
		{
			return vtkIdList.vtkIdList_Allocate_01(base.GetCppThis(), sz, strategy);
		}

		// Token: 0x0601E4A6 RID: 124070
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_DeepCopy_02(HandleRef pThis, HandleRef ids);

		/// <summary>
		/// Copy an id list by explicitly copying the internal array.
		/// </summary>
		// Token: 0x0601E4A7 RID: 124071 RVA: 0x002AD9E8 File Offset: 0x002ABBE8
		public void DeepCopy(vtkIdList ids)
		{
			vtkIdList.vtkIdList_DeepCopy_02(base.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601E4A8 RID: 124072
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_DeleteId_03(HandleRef pThis, long vtkid);

		/// <summary>
		/// Delete specified id from list. Will remove all occurrences of id in list.
		/// </summary>
		// Token: 0x0601E4A9 RID: 124073 RVA: 0x002ADA17 File Offset: 0x002ABC17
		public void DeleteId(long vtkid)
		{
			vtkIdList.vtkIdList_DeleteId_03(base.GetCppThis(), vtkid);
		}

		// Token: 0x0601E4AA RID: 124074
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_Fill_04(HandleRef pThis, long value);

		/// <summary>
		/// Fill the ids with the input value. This method uses
		/// vtkSMPTools::Fill() so it can be sped up if built properly.
		/// </summary>
		// Token: 0x0601E4AB RID: 124075 RVA: 0x002ADA27 File Offset: 0x002ABC27
		public void Fill(long value)
		{
			vtkIdList.vtkIdList_Fill_04(base.GetCppThis(), value);
		}

		// Token: 0x0601E4AC RID: 124076
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_FindIdLocation_05(HandleRef pThis, long id);

		/// <summary>
		/// Find the location i of the provided id.
		/// </summary>
		// Token: 0x0601E4AD RID: 124077 RVA: 0x002ADA38 File Offset: 0x002ABC38
		public long FindIdLocation(long id)
		{
			return vtkIdList.vtkIdList_FindIdLocation_05(base.GetCppThis(), id);
		}

		// Token: 0x0601E4AE RID: 124078
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_GetId_06(HandleRef pThis, long i);

		/// <summary>
		/// Return the id at location i.
		/// </summary>
		// Token: 0x0601E4AF RID: 124079 RVA: 0x002ADA58 File Offset: 0x002ABC58
		public long GetId(long i)
		{
			return vtkIdList.vtkIdList_GetId_06(base.GetCppThis(), i);
		}

		// Token: 0x0601E4B0 RID: 124080
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4B1 RID: 124081 RVA: 0x002ADA78 File Offset: 0x002ABC78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIdList.vtkIdList_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E4B2 RID: 124082
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4B3 RID: 124083 RVA: 0x002ADA98 File Offset: 0x002ABC98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIdList.vtkIdList_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601E4B4 RID: 124084
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_GetNumberOfIds_09(HandleRef pThis);

		/// <summary>
		/// Return the number of id's in the list.
		/// </summary>
		// Token: 0x0601E4B5 RID: 124085 RVA: 0x002ADAB4 File Offset: 0x002ABCB4
		public long GetNumberOfIds()
		{
			return vtkIdList.vtkIdList_GetNumberOfIds_09(base.GetCppThis());
		}

		// Token: 0x0601E4B6 RID: 124086
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_GetPointer_10(HandleRef pThis, long i);

		/// <summary>
		/// Get a pointer to a particular data index.
		/// </summary>
		// Token: 0x0601E4B7 RID: 124087 RVA: 0x002ADAD4 File Offset: 0x002ABCD4
		public IntPtr GetPointer(long i)
		{
			return vtkIdList.vtkIdList_GetPointer_10(base.GetCppThis(), i);
		}

		// Token: 0x0601E4B8 RID: 124088
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_Initialize_11(HandleRef pThis);

		/// <summary>
		/// Release memory and restore to unallocated state.
		/// </summary>
		// Token: 0x0601E4B9 RID: 124089 RVA: 0x002ADAF4 File Offset: 0x002ABCF4
		public void Initialize()
		{
			vtkIdList.vtkIdList_Initialize_11(base.GetCppThis());
		}

		// Token: 0x0601E4BA RID: 124090
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_InsertId_12(HandleRef pThis, long i, long vtkid);

		/// <summary>
		/// Set the id at location i. Does range checking and allocates memory
		/// as necessary.
		/// </summary>
		// Token: 0x0601E4BB RID: 124091 RVA: 0x002ADB03 File Offset: 0x002ABD03
		public void InsertId(long i, long vtkid)
		{
			vtkIdList.vtkIdList_InsertId_12(base.GetCppThis(), i, vtkid);
		}

		// Token: 0x0601E4BC RID: 124092
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_InsertNextId_13(HandleRef pThis, long vtkid);

		/// <summary>
		/// Add the id specified to the end of the list. Range checking is performed.
		/// </summary>
		// Token: 0x0601E4BD RID: 124093 RVA: 0x002ADB14 File Offset: 0x002ABD14
		public long InsertNextId(long vtkid)
		{
			return vtkIdList.vtkIdList_InsertNextId_13(base.GetCppThis(), vtkid);
		}

		// Token: 0x0601E4BE RID: 124094
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_InsertUniqueId_14(HandleRef pThis, long vtkid);

		/// <summary>
		/// If id is not already in list, insert it and return location in
		/// list. Otherwise return just location in list.
		/// </summary>
		// Token: 0x0601E4BF RID: 124095 RVA: 0x002ADB34 File Offset: 0x002ABD34
		public long InsertUniqueId(long vtkid)
		{
			return vtkIdList.vtkIdList_InsertUniqueId_14(base.GetCppThis(), vtkid);
		}

		// Token: 0x0601E4C0 RID: 124096
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_IntersectWith_15(HandleRef pThis, HandleRef otherIds);

		/// <summary>
		/// Intersect this list with another vtkIdList. Updates current list according
		/// to result of intersection operation.
		/// </summary>
		// Token: 0x0601E4C1 RID: 124097 RVA: 0x002ADB54 File Offset: 0x002ABD54
		public void IntersectWith(vtkIdList otherIds)
		{
			vtkIdList.vtkIdList_IntersectWith_15(base.GetCppThis(), (otherIds == null) ? default(HandleRef) : otherIds.GetCppThis());
		}

		// Token: 0x0601E4C2 RID: 124098
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdList_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4C3 RID: 124099 RVA: 0x002ADB84 File Offset: 0x002ABD84
		public override int IsA(string type)
		{
			return vtkIdList.vtkIdList_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601E4C4 RID: 124100
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdList_IsId_17(HandleRef pThis, long vtkid);

		/// <summary>
		/// Return -1 if id specified is not contained in the list; otherwise return
		/// the position in the list.
		/// </summary>
		// Token: 0x0601E4C5 RID: 124101 RVA: 0x002ADBA4 File Offset: 0x002ABDA4
		public long IsId(long vtkid)
		{
			return vtkIdList.vtkIdList_IsId_17(base.GetCppThis(), vtkid);
		}

		// Token: 0x0601E4C6 RID: 124102
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdList_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4C7 RID: 124103 RVA: 0x002ADBC4 File Offset: 0x002ABDC4
		public new static int IsTypeOf(string type)
		{
			return vtkIdList.vtkIdList_IsTypeOf_18(type);
		}

		// Token: 0x0601E4C8 RID: 124104
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4C9 RID: 124105 RVA: 0x002ADBE0 File Offset: 0x002ABDE0
		public new vtkIdList NewInstance()
		{
			vtkIdList result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdList.vtkIdList_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E4CA RID: 124106
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_Release_21(HandleRef pThis);

		/// <summary>
		/// This releases the ownership of the internal vtkIdType array and returns the
		/// pointer to it. The caller is responsible of calling `delete []` on the
		/// returned value. This vtkIdList will be set to initialized state after this
		/// call.
		/// </summary>
		// Token: 0x0601E4CB RID: 124107 RVA: 0x002ADC3C File Offset: 0x002ABE3C
		public IntPtr Release()
		{
			return vtkIdList.vtkIdList_Release_21(base.GetCppThis());
		}

		// Token: 0x0601E4CC RID: 124108
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_Reset_22(HandleRef pThis);

		/// <summary>
		/// Reset to an empty state but retain previously allocated memory.
		/// </summary>
		// Token: 0x0601E4CD RID: 124109 RVA: 0x002ADC5B File Offset: 0x002ABE5B
		public void Reset()
		{
			vtkIdList.vtkIdList_Reset_22(base.GetCppThis());
		}

		// Token: 0x0601E4CE RID: 124110
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_Resize_23(HandleRef pThis, long sz);

		/// <summary>
		/// Adjust the size of the id list while maintaining its content (except
		/// when being truncated).
		/// </summary>
		// Token: 0x0601E4CF RID: 124111 RVA: 0x002ADC6C File Offset: 0x002ABE6C
		public IntPtr Resize(long sz)
		{
			return vtkIdList.vtkIdList_Resize_23(base.GetCppThis(), sz);
		}

		// Token: 0x0601E4D0 RID: 124112
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601E4D1 RID: 124113 RVA: 0x002ADC8C File Offset: 0x002ABE8C
		public new static vtkIdList SafeDownCast(vtkObjectBase o)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdList.vtkIdList_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601E4D2 RID: 124114
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_SetArray_25(HandleRef pThis, IntPtr array, long size, byte save);

		/// <summary>
		/// Specify an array of vtkIdType to use as the id list. This replaces the
		/// underlying array. This instance of vtkIdList takes ownership of the
		/// array, meaning that it deletes it on destruction (using delete[]).
		/// </summary>
		// Token: 0x0601E4D3 RID: 124115 RVA: 0x002ADD0B File Offset: 0x002ABF0B
		public void SetArray(IntPtr array, long size, bool save)
		{
			vtkIdList.vtkIdList_SetArray_25(base.GetCppThis(), array, size, save ? (byte)1 : (byte)0);
		}

		// Token: 0x0601E4D4 RID: 124116
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_SetId_26(HandleRef pThis, long i, long vtkid);

		/// <summary>
		/// Set the id at location i. Doesn't do range checking so it's a bit
		/// faster than InsertId. Make sure you use SetNumberOfIds() to allocate
		/// memory prior to using SetId().
		/// </summary>
		// Token: 0x0601E4D5 RID: 124117 RVA: 0x002ADD25 File Offset: 0x002ABF25
		public void SetId(long i, long vtkid)
		{
			vtkIdList.vtkIdList_SetId_26(base.GetCppThis(), i, vtkid);
		}

		// Token: 0x0601E4D6 RID: 124118
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_SetNumberOfIds_27(HandleRef pThis, long number);

		/// <summary>
		/// Specify the number of ids for this object to hold. Does an
		/// allocation as well as setting the number of ids.
		/// </summary>
		// Token: 0x0601E4D7 RID: 124119 RVA: 0x002ADD36 File Offset: 0x002ABF36
		public void SetNumberOfIds(long number)
		{
			vtkIdList.vtkIdList_SetNumberOfIds_27(base.GetCppThis(), number);
		}

		// Token: 0x0601E4D8 RID: 124120
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_Sort_28(HandleRef pThis);

		/// <summary>
		/// Sort the ids in the list in ascending id order. This method uses
		/// vtkSMPTools::Sort() so it can be sped up if built properly.
		/// </summary>
		// Token: 0x0601E4D9 RID: 124121 RVA: 0x002ADD46 File Offset: 0x002ABF46
		public void Sort()
		{
			vtkIdList.vtkIdList_Sort_28(base.GetCppThis());
		}

		// Token: 0x0601E4DA RID: 124122
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdList_Squeeze_29(HandleRef pThis);

		/// <summary>
		/// Free any unused memory.
		/// </summary>
		// Token: 0x0601E4DB RID: 124123 RVA: 0x002ADD55 File Offset: 0x002ABF55
		public void Squeeze()
		{
			vtkIdList.vtkIdList_Squeeze_29(base.GetCppThis());
		}

		// Token: 0x0601E4DC RID: 124124
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_WritePointer_30(HandleRef pThis, long i, long number);

		/// <summary>
		/// Get a pointer to a particular data index. Make sure data is allocated
		/// for the number of items requested. Set MaxId according to the number of
		/// data values requested.
		/// </summary>
		// Token: 0x0601E4DD RID: 124125 RVA: 0x002ADD64 File Offset: 0x002ABF64
		public IntPtr WritePointer(long i, long number)
		{
			return vtkIdList.vtkIdList_WritePointer_30(base.GetCppThis(), i, number);
		}

		// Token: 0x0601E4DE RID: 124126
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_begin_31(HandleRef pThis);

		/// <summary>
		/// To support range-based `for` loops
		/// </summary>
		// Token: 0x0601E4DF RID: 124127 RVA: 0x002ADD88 File Offset: 0x002ABF88
		public IntPtr begin()
		{
			return vtkIdList.vtkIdList_begin_31(base.GetCppThis());
		}

		// Token: 0x0601E4E0 RID: 124128
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdList_end_32(HandleRef pThis);

		/// <summary>
		/// To support range-based `for` loops
		/// </summary>
		// Token: 0x0601E4E1 RID: 124129 RVA: 0x002ADDA8 File Offset: 0x002ABFA8
		public IntPtr end()
		{
			return vtkIdList.vtkIdList_end_32(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002089 RID: 8329
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdList";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400208A RID: 8330
		public new static readonly string MRClassNameKey = "class vtkIdList";
	}
}
