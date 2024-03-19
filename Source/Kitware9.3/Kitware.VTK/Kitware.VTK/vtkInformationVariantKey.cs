using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationVariantKey
	/// </summary>
	/// <remarks>
	///    Key for variant values in vtkInformation.
	///
	/// vtkInformationVariantKey is used to represent keys for variant values
	/// in vtkInformation.
	/// </remarks>
	// Token: 0x02000B69 RID: 2921
	public class vtkInformationVariantKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E818 RID: 124952 RVA: 0x002B4574 File Offset: 0x002B2774
		static vtkInformationVariantKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationVariantKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationVariantKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E819 RID: 124953 RVA: 0x002B459C File Offset: 0x002B279C
		public vtkInformationVariantKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E81A RID: 124954 RVA: 0x002B45AA File Offset: 0x002B27AA
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E81B RID: 124955
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantKey_Get_01(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E81C RID: 124956 RVA: 0x002B45B8 File Offset: 0x002B27B8
		public vtkVariant Get(vtkInformation info)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantKey.vtkInformationVariantKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E81D RID: 124957
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationVariantKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E81E RID: 124958 RVA: 0x002B4628 File Offset: 0x002B2828
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationVariantKey.vtkInformationVariantKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E81F RID: 124959
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationVariantKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E820 RID: 124960 RVA: 0x002B4648 File Offset: 0x002B2848
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationVariantKey.vtkInformationVariantKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E821 RID: 124961
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVariantKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E822 RID: 124962 RVA: 0x002B4664 File Offset: 0x002B2864
		public override int IsA(string type)
		{
			return vtkInformationVariantKey.vtkInformationVariantKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E823 RID: 124963
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationVariantKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E824 RID: 124964 RVA: 0x002B4684 File Offset: 0x002B2884
		public new static int IsTypeOf(string type)
		{
			return vtkInformationVariantKey.vtkInformationVariantKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E825 RID: 124965
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationVariantKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E826 RID: 124966 RVA: 0x002B46A0 File Offset: 0x002B28A0
		public static vtkInformationVariantKey MakeKey(string name, string location)
		{
			vtkInformationVariantKey vtkInformationVariantKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantKey.vtkInformationVariantKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVariantKey = (vtkInformationVariantKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVariantKey.Register(null);
				}
			}
			return vtkInformationVariantKey;
		}

		// Token: 0x0601E827 RID: 124967
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E828 RID: 124968 RVA: 0x002B470C File Offset: 0x002B290C
		public new vtkInformationVariantKey NewInstance()
		{
			vtkInformationVariantKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantKey.vtkInformationVariantKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationVariantKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E829 RID: 124969
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationVariantKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E82A RID: 124970 RVA: 0x002B4768 File Offset: 0x002B2968
		public new static vtkInformationVariantKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationVariantKey vtkInformationVariantKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationVariantKey.vtkInformationVariantKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVariantKey = (vtkInformationVariantKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVariantKey.Register(null);
				}
			}
			return vtkInformationVariantKey;
		}

		// Token: 0x0601E82B RID: 124971
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVariantKey_Set_09(HandleRef pThis, HandleRef info, HandleRef arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E82C RID: 124972 RVA: 0x002B47E8 File Offset: 0x002B29E8
		public void Set(vtkInformation info, vtkVariant arg1)
		{
			vtkInformationVariantKey.vtkInformationVariantKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E82D RID: 124973
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationVariantKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E82E RID: 124974 RVA: 0x002B482C File Offset: 0x002B2A2C
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationVariantKey.vtkInformationVariantKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B1 RID: 8369
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationVariantKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B2 RID: 8370
		public new static readonly string MRClassNameKey = "class vtkInformationVariantKey";
	}
}
