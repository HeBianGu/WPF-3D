using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationVariantVectorKey
	/// </summary>
	/// <remarks>
	///    Key for variant vector values.
	///
	/// vtkInformationVariantVectorKey is used to represent keys for variant
	/// vector values in vtkInformation.h
	/// </remarks>
	// Token: 0x02000B6A RID: 2922
	public class vtkInformationVariantVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E82F RID: 124975 RVA: 0x002B4870 File Offset: 0x002B2A70
		static vtkInformationVariantVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationVariantVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationVariantVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E830 RID: 124976 RVA: 0x002B4898 File Offset: 0x002B2A98
		public vtkInformationVariantVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E831 RID: 124977 RVA: 0x002B48A6 File Offset: 0x002B2AA6
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E832 RID: 124978
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVariantVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E833 RID: 124979 RVA: 0x002B48B4 File Offset: 0x002B2AB4
		public void Append(vtkInformation info, vtkVariant value)
		{
			vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E834 RID: 124980
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantVectorKey_Get_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E835 RID: 124981 RVA: 0x002B48F8 File Offset: 0x002B2AF8
		public vtkVariant Get(vtkInformation info)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x0601E836 RID: 124982
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E837 RID: 124983 RVA: 0x002B4968 File Offset: 0x002B2B68
		public vtkVariant Get(vtkInformation info, int idx)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E838 RID: 124984
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVariantVectorKey_Get_04(HandleRef pThis, HandleRef info, HandleRef value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E839 RID: 124985 RVA: 0x002B49DC File Offset: 0x002B2BDC
		public void Get(vtkInformation info, vtkVariant value)
		{
			vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E83A RID: 124986
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationVariantVectorKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E83B RID: 124987 RVA: 0x002B4A20 File Offset: 0x002B2C20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E83C RID: 124988
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationVariantVectorKey_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E83D RID: 124989 RVA: 0x002B4A40 File Offset: 0x002B2C40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E83E RID: 124990
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVariantVectorKey_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E83F RID: 124991 RVA: 0x002B4A5C File Offset: 0x002B2C5C
		public override int IsA(string type)
		{
			return vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E840 RID: 124992
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVariantVectorKey_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E841 RID: 124993 RVA: 0x002B4A7C File Offset: 0x002B2C7C
		public new static int IsTypeOf(string type)
		{
			return vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_IsTypeOf_08(type);
		}

		// Token: 0x0601E842 RID: 124994
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVariantVectorKey_Length_09(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E843 RID: 124995 RVA: 0x002B4A98 File Offset: 0x002B2C98
		public int Length(vtkInformation info)
		{
			return vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_Length_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E844 RID: 124996
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantVectorKey_MakeKey_10([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, int length, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationVariantVectorKey, given a
		/// name, a location and a required length. This method is provided for
		/// wrappers. Use the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E845 RID: 124997 RVA: 0x002B4ACC File Offset: 0x002B2CCC
		public static vtkInformationVariantVectorKey MakeKey(string name, string location, int length)
		{
			vtkInformationVariantVectorKey vtkInformationVariantVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_MakeKey_10(name, location, length, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVariantVectorKey = (vtkInformationVariantVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVariantVectorKey.Register(null);
				}
			}
			return vtkInformationVariantVectorKey;
		}

		// Token: 0x0601E846 RID: 124998
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantVectorKey_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E847 RID: 124999 RVA: 0x002B4B38 File Offset: 0x002B2D38
		public new vtkInformationVariantVectorKey NewInstance()
		{
			vtkInformationVariantVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationVariantVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E848 RID: 125000
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantVectorKey_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E849 RID: 125001 RVA: 0x002B4B94 File Offset: 0x002B2D94
		public new static vtkInformationVariantVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationVariantVectorKey vtkInformationVariantVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVariantVectorKey = (vtkInformationVariantVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVariantVectorKey.Register(null);
				}
			}
			return vtkInformationVariantVectorKey;
		}

		// Token: 0x0601E84A RID: 125002
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVariantVectorKey_Set_13(HandleRef pThis, HandleRef info, HandleRef value, int length);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E84B RID: 125003 RVA: 0x002B4C14 File Offset: 0x002B2E14
		public void Set(vtkInformation info, vtkVariant value, int length)
		{
			vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_Set_13(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), length);
		}

		// Token: 0x0601E84C RID: 125004
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVariantVectorKey_ShallowCopy_14(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E84D RID: 125005 RVA: 0x002B4C5C File Offset: 0x002B2E5C
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationVariantVectorKey.vtkInformationVariantVectorKey_ShallowCopy_14(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B3 RID: 8371
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationVariantVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B4 RID: 8372
		public new static readonly string MRClassNameKey = "class vtkInformationVariantVectorKey";
	}
}
