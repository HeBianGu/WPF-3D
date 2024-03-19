using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationInformationVectorKey
	/// </summary>
	/// <remarks>
	///    Key for vtkInformation vectors.
	///
	/// vtkInformationInformationVectorKey is used to represent keys in
	/// vtkInformation for vectors of other vtkInformation objects.
	/// </remarks>
	// Token: 0x02000B5D RID: 2909
	public class vtkInformationInformationVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E6D2 RID: 124626 RVA: 0x002B1E5C File Offset: 0x002B005C
		static vtkInformationInformationVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationInformationVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationInformationVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6D3 RID: 124627 RVA: 0x002B1E84 File Offset: 0x002B0084
		public vtkInformationInformationVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6D4 RID: 124628 RVA: 0x002B1E92 File Offset: 0x002B0092
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E6D5 RID: 124629
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationVectorKey_DeepCopy_01(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Duplicate (new instance created) the entry associated with this key from
		/// one information object to another (new instances of any contained
		/// vtkInformation and vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E6D6 RID: 124630 RVA: 0x002B1EA0 File Offset: 0x002B00A0
		public override void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_DeepCopy_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x0601E6D7 RID: 124631
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationVectorKey_Get_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6D8 RID: 124632 RVA: 0x002B1EE4 File Offset: 0x002B00E4
		public vtkInformationVector Get(vtkInformation info)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		// Token: 0x0601E6D9 RID: 124633
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationInformationVectorKey_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6DA RID: 124634 RVA: 0x002B1F6C File Offset: 0x002B016C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E6DB RID: 124635
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationInformationVectorKey_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6DC RID: 124636 RVA: 0x002B1F8C File Offset: 0x002B018C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601E6DD RID: 124637
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationInformationVectorKey_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6DE RID: 124638 RVA: 0x002B1FA8 File Offset: 0x002B01A8
		public override int IsA(string type)
		{
			return vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E6DF RID: 124639
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationInformationVectorKey_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6E0 RID: 124640 RVA: 0x002B1FC8 File Offset: 0x002B01C8
		public new static int IsTypeOf(string type)
		{
			return vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_IsTypeOf_06(type);
		}

		// Token: 0x0601E6E1 RID: 124641
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationVectorKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6E2 RID: 124642 RVA: 0x002B1FE4 File Offset: 0x002B01E4
		public new vtkInformationInformationVectorKey NewInstance()
		{
			vtkInformationInformationVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E6E3 RID: 124643
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationVectorKey_Report_08(HandleRef pThis, HandleRef info, HandleRef collector);

		/// <summary>
		/// Report a reference this key has in the given information object.
		/// </summary>
		// Token: 0x0601E6E4 RID: 124644 RVA: 0x002B2040 File Offset: 0x002B0240
		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_Report_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		// Token: 0x0601E6E5 RID: 124645
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationVectorKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6E6 RID: 124646 RVA: 0x002B2084 File Offset: 0x002B0284
		public new static vtkInformationInformationVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x0601E6E7 RID: 124647
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationVectorKey_Set_10(HandleRef pThis, HandleRef info, HandleRef arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6E8 RID: 124648 RVA: 0x002B2104 File Offset: 0x002B0304
		public void Set(vtkInformation info, vtkInformationVector arg1)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E6E9 RID: 124649
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationVectorKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E6EA RID: 124650 RVA: 0x002B2148 File Offset: 0x002B0348
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationInformationVectorKey.vtkInformationInformationVectorKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002099 RID: 8345
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationInformationVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400209A RID: 8346
		public new static readonly string MRClassNameKey = "class vtkInformationInformationVectorKey";
	}
}
